using System;
using System.Collections.Generic;

namespace Modules
{
    public class Product : IComparable<Product>
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

        //--------------------------Constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nm"></param>
        /// <param name="prc"></param>
        /// <param name="qntt"></param>
        public Product(int id, string nm)
        {
            this.Id = id;
            this.Name = nm;
        }

        /// <summary>
        /// Shows information about a product
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
        }

        public int CompareTo(Product obj)
        {
            return string.Compare(this.Name, obj.Name);
        }
    }

    public class ProductToSell : Product
    {
        public double Price
        {
            get; private set;
        }
        public int Quantity
        {
            get; private set;
        }

        //------------------------------Methods

        public void LowerQuantityBy(int amount)
        {
            if (amount >= 0)
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


        public ProductToSell(int id, string nm, double prc, int qntt)
            : base(id, nm)
        {
            this.Price = prc;
            this.Quantity = qntt;
        }

        public override string ToString()
        {
            return base.ToString() + "   -   price: " + this.Price.ToString() + "   -   quantity: " + this.Quantity.ToString();
        }

    }

    public class ProductArchive : Product
    {
        public DateTime SliceTime;
        public int QuantityArch;
        public int NumSoldArch;

        public ProductArchive(int id, string nm, DateTime stime, int numsoldArch, int qnttyArch)
            :base(id,nm)
        {
            this.SliceTime = stime;
            this.QuantityArch = qnttyArch;
            this.NumSoldArch = numsoldArch;
        }
    }

}
