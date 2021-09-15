using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class AutomatData
    {

        Product cocaCola = new Product("Coca Cola", 14, 10, 1);
        Product squash = new Product("Squash", 14, 0, 2);
        Product faxeKondi = new Product("Faxe Kondi", 14, 10, 3);
        Product skumBananer = new Product("Skumbananer", 20, 12, 4);
        Product vingummiBamser = new Product("Vingummi Bamser", 16, 10, 5);
        Product salteFisk = new Product("Salte Fisk", 16, 10, 6);
        private List<Product> products;

        private int moneyInMachine;

        public int MoneyInMachine
        {
            get { return moneyInMachine; }
            set { moneyInMachine = value; }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }


        public AutomatData()
        {
            products = new List<Product>();
            products.Add(cocaCola);
            products.Add(squash);
            products.Add(faxeKondi);
            products.Add(skumBananer);
            products.Add(vingummiBamser);
            products.Add(salteFisk);
        }

       
    }
    
}
