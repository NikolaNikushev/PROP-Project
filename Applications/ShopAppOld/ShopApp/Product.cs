using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Product
    {
        private string name;
        private double price;
        private int quantity;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
            public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public Product(string nm, double prc, int qntt)
        {
            this.name = nm;
            this.price = prc;
            this.quantity = qntt;
        }

        public string getInfo()
        {
            return this.name + "   -   price: " + this.price.ToString() + "   -   quantity: " + this.quantity.ToString();
        }
    }
}
