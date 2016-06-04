using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Product
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

        public string getInfo()
        {
            return this.Name + "   -   price: " + this.Price.ToString() + "   -   quantity: " + this.Quantity.ToString();
        }
    }
}
