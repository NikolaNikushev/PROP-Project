using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Shop
    {
        List<Product> Stock;
        DBHelper dbh;
        public void Initialize()
        {
            List<Product> Stock = new List<Product>();
            DBHelper dbh=new DBHelper();
            Stock = dbh.GetAllProducts();
        }
        public void LowerQuantity(string name, int quantity)
        {
            foreach(Product p in Stock)
            {
                if (p.Name == name)
                {
                    
                }
            }
        }
    }
}
