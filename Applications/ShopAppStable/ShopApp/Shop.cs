using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Shop
    {
        private List<Product> stock;
        private List<Product> basket;
        private DBHelper dbh;
        private int storeID;

        public List<Product> Stock
        {
            get { return this.stock; }
            private set { this.stock = value; }
        }

        /// <summary>
        /// Constructor for the shop
        /// </summary>
        public Shop()
        {
            this.stock = new List<Product>();
            this.dbh=new DBHelper();
            this.stock = dbh.GetAllProducts();
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
