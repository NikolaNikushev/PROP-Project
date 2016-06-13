using System;

namespace Modules
{
    public class Product: IComparable<Product>
    {
        // all the fields are retrieved from the DB
        public int Id
        {
            get; private set;
        }
        public string Name
        {
            get; private set;
        }
        public double Price
        {
            get; private set;
        }
        public int Quantity
        {
            get; private set;
        }




        //--------------------------Constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nm"></param>
        /// <param name="prc"></param>
        /// <param name="qntt"></param>
        public Product(int id, string nm, double prc, int qntt)
        {
            this.Id = id;
            this.Name = nm;
            this.Price = prc;
            this.Quantity = qntt;
        }
        

        //------------------------------Methods

        public void LowerQuantityBy(int amount)
        {
            if(amount>=0)
            {
                this.Quantity -= amount;
            }
        }
        public void IncreaseQuantityBy(int amount)
        {
            if (amount >= 0)
            {
                this.Quantity += amount;
            }
        }

        /// <summary>
        /// Shows information about a product
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name + "   -   price: " + this.Price.ToString() + "   -   quantity: " + this.Quantity.ToString();
        }

        public int CompareTo(Product obj)
        {
            return string.Compare(this.Name,obj.Name);
        }
    }
}
