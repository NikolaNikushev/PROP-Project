using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoaningItemsApp
{
    class LoanShopp
    {
        public string Name { get; set; }
        public List<Item> LoanItems;
        DBHelper dbh;
        public LoanShopp(string name)
        {
            Name = name;
            dbh = new DBHelper();
            LoanItems = dbh.GetAllItems();
            
        }
    }
}
