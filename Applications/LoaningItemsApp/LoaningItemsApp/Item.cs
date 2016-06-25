using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoaningItemsApp
{
    class Item
    {
        private string name;
        private bool loaned;
        private int priceperday;
        private DateTime returndate;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }

        }
        public bool Loaned
        {
            get
            {
                return loaned;
            }
            set
            {
                loaned = value;
            }
        }
        public int Priceperday
        {
            get
            {
                return priceperday;
            }
            set
            {
                priceperday = value;
            }
        }
        public DateTime Returndate
        {
            get
            {
                return returndate;
            }
            set
            {
                returndate = value;
            }
        }
        public Item(string name, bool loaned, int priceperday, DateTime returndate)
        {
            this.Name = name;
            this.Loaned = loaned;
            this.Priceperday = priceperday;
            this.Returndate = returndate;
        }
        public string AsString()
        {
            string s = "Name of article: " + Name + " Price per day: " + Priceperday.ToString();
            if(Loaned== true)
            {
                s += " Item is already loaned out" + " and will be returned on: " + Returndate.ToString();
                return s;
            }
            else if(Loaned==false)
            {
                s += " Item is available";
                return s;
            }
            return s;
            
        }

        public static implicit operator Item(string v)
        {
            throw new NotImplementedException();
        }
    }
}
