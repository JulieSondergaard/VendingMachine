using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VendingMachine
{
    class AutomatLogic
    {
        AutomatData productData = new AutomatData();
       

        public List<Product> GetProductData()
        {

            return productData.Products();
        }
        

        public void Payment(int index)
        {
            Console.Clear();
            Console.WriteLine("{0} ~ insert {1} kr. ", productData.Products()[index-1].ProductName, productData.Products()[index-1].ProductPrice);
            bool repeat = true;
            int coins = 0;
            int temp;
            do { 
           
                temp = int.Parse(Console.ReadLine());
                coins += temp;
                int missing = productData.Products()[index-1].ProductPrice - coins;

                

                if (productData.Products()[index-1].ProductPrice > coins)
                {
                   Console.Clear();                    
                   Console.WriteLine("Insert {0} kr.", missing);
               
                
                }
                else if (productData.Products()[index-1].ProductPrice == coins)
                {
                    Console.Clear();
                    Console.WriteLine("The product will come out in the bottom. \nEnjoy your purchase!");
                    Thread.Sleep(3000);
                    repeat = false;
                }
                else if (productData.Products()[index - 1].ProductPrice < coins)
                {
                    
                    Console.Clear();
                    Console.WriteLine("You can not insert more money than the products price. ", coins);
                    missing += temp;
                    coins -= temp;
                    Console.WriteLine("Insert {0} kr.", missing);
                }                        
            } while (repeat == true);
        }
        public void GetAdminMenu()
        {

        }

    }
}
