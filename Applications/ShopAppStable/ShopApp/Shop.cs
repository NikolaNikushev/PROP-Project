using System;
using System.Collections.Generic;

namespace ShopApp
{
    class Shop
    {
        
        private List<Product> stock;
        private List<Product> basket;
        private DBHelper dbh;

        public int Id
        {
            get; private set;
        }
        public string Name
        {
            get; private set;
        }

        public List<Product> Stock
        {
            get { return this.stock; }
            private set { this.stock = value; }
        }
        public List<Product> Basket
        {
            get { return this.basket; }
            private set { this.basket = value; }
        }

        public double TotalPrice
        {
            get
            {
                double totalPrice = 0;
                foreach(Product p in this.basket)
                {
                    totalPrice += p.Price * p.Quantity;
                }
                return totalPrice;
            }
        }

        /// <summary>
        /// Constructor for a shop without a name
        /// </summary>
        public Shop()
        {
            this.stock = new List<Product>();
            this.basket = new List<Product>();
            this.dbh = new DBHelper();
            this.stock = dbh.GetAllProducts();
        }

        /// <summary>
        /// Constructs an object of type shop with a specified name
        /// makes sense for a chosenShop
        /// </summary>
        /// <param name="name"></param>
        public Shop(string name)
        {
            this.Name = name;
            
            this.stock = new List<Product>();
            this.basket = new List<Product>();
            this.dbh = new DBHelper();
            try
            {
                this.stock = dbh.GetAllProducts(this.Name);
                this.Id = dbh.GetStoreId(this.Name);
            }
            catch(Exception ex)
            {
                throw new Exception("Something went wrong with DB, it says - " + ex.Message);
            }
            

        }


        //-------------------------------Methods

        public void SortListByName(List<Product> listTiSort)
        {
            listTiSort.Sort();
        }


        /// <summary>
        /// Moves accroding number of products to the basket
        /// </summary>
        /// <param name="productToBasket"></param>
        public void AddToBasket(Product productToBasket)
        {
            Product temp = getProductByName(productToBasket.Name, this.basket);
            if (temp == null)
            {
                this.basket.Add(productToBasket);
            }
            else
            {
                // is not empty and exists as a refernce to the element
                temp.IncreaseQuantityBy(productToBasket.Quantity);
            }
        }

        /// <summary>
        /// Retrieve the quantity of a product in stock of a current store (this.Id)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetStockQunatityInStoreByProductID(int id)
        {
            int funcRes = 0;
            funcRes = this.dbh.GetQuantity(this.Id, id);
            return funcRes;
        }

        /// <summary>
        /// retrieves all the products with a specified name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="listToManage"></param>
        /// <returns></returns>
        public Product getProductByName(string name, List<Product> listToManage)
        {
            SortListByName(listToManage);
            Product result = this.BinarySearchByName(name, 0, listToManage.Count - 1, listToManage);
            return result;
        }

        private Product BinarySearchByName(string name, int lowIndex, int highIndex, List<Product> listToManage)
        {
            //Binary search works on sorted arrays. A binary search begins by 
            //comparing the middle element of the array with the target 
            //value. If the target value matches the middle element, its
            //position in the array is returned. If the target value is 
            //less or more than the middle element, the search continues the 
            //lower or upper half of the array respectively with a new 
            //middle element, eliminating the other half from consideration.[6]

            //1. Set L to 0 and R to n − 1.
            //2. If L > R, the search terminates as unsuccessful.Set m(the position of the middle element) to the floor of (L + R) / 2.
            //3. If Am < T, set L to m + 1 and go to step 2.
            //4. If Am > T, set R to m − 1 and go to step 2.
            //5. If Am = T, the search is done; return m.
            /// \
            // | from wikipedia

            if (lowIndex <= highIndex)
            {
                int middle = (highIndex + lowIndex) / 2;
                // if the delivery buyer's name contains the searched text then 
                if ((listToManage[middle].Name.ToUpper()).Contains(name.ToUpper()))
                {
                    return listToManage[middle];
                }

                // if the id is lower than the expected one
                if (String.Compare(listToManage[middle].Name.ToUpper(), name.ToUpper()) < 0)
                {
                    lowIndex = middle + 1;
                }
                // if the id is higher than the expected one
                else if (String.Compare(listToManage[middle].Name.ToUpper(), name.ToUpper()) > 0)
                {
                    highIndex = middle - 1;
                }
                else
                // equal! search complete.
                {
                    // returns the found element and terminates
                    return listToManage[middle];
                }
                // if did not return goes again into the cycle
                return this.BinarySearchByName(name, lowIndex, highIndex, listToManage);
            }
            else
            {
                return null;
            }
        }

        //public void LowerQuantity(string name, int quantity)
        //{
        //    foreach(Product p in Stock)
        //    {
        //        if (p.Name == name)
        //        {

        //        }
        //    }
        //}
    }
}
