using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoaningItemsApp
{
    class Item
    {
        private int article_id;
        private string name;
        private int loaned;
        private int priceperday;
        private DateTime returndate;
        private DateTime loandate;
        private DateTime actualreturndate;
        public DateTime Actualreturndate { get { return actualreturndate; } set { actualreturndate = value; } }
        public DateTime Loandate
        
           
        {
            get { return loandate; }
            set
            {
                loandate = value;
            }
        }
        public int Article_id
        {
            get { return article_id; }
            set
            {
                article_id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }

        }
        public int Loaned
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
        public Item(int article_id, string name, int loaned, int priceperday, DateTime returndate, DateTime loandate)
        {
            this.Name = name;
            this.Loaned = loaned;
            this.Priceperday = priceperday;
            this.Returndate = returndate;
            this.Loandate = loandate;
            this.Article_id = article_id;
        }
        public  string AsString()
        {
            string s = "Name of article: " + Name + " Price per day: " + Priceperday.ToString();
            if(Loaned== 1)
            {
                s += " Item is already loaned out" + " and will be returned on: " + Returndate.ToString();
                return s;
            }
            else if(Loaned==0)
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
        public override string ToString()
        {
            string s = "Name of article: " + Name + " Price per day: " + Priceperday.ToString();
            if (Loaned == 1)
            {
                s += " Item is already loaned out" + " and will be returned on: " + Returndate.ToString();
                return s;
            }
            else if (Loaned == 0)
            {
                s += " Item is available";
                return s;
            }
            return s;

        }
    }
}
