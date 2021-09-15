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
        // This menu class is getting all it's data from the Program class, where AutomatData is instantiated, and is sending it's data back to Program,
        // where there is made a instantiation of this class, using data from AutomatData.

        AutomatData productData;
        //Money money;


      


        public List<Product> GetProductData()
        {

            return productData.Products;
        }

        public AutomatLogic(AutomatData data)
        {
            productData = data;
            
        }
        public int GetMoneyMachine()
        {
            return productData.MoneyInMachine;
        }
        public void SetMoneyMachine(int value)
        {
            productData.MoneyInMachine = value;
        }

       


        public void Payment(int index)
        {

            
            Console.Clear();
            Console.WriteLine("{0} ~ insert {1} kr. ", productData.Products[index-1].ProductName, productData.Products[index-1].ProductPrice);
            bool repeat = true;
            int coins = 0;
            int temp;
            do { 
           
                temp = int.Parse(Console.ReadLine());
                coins += temp;
                int missing = productData.Products[index-1].ProductPrice - coins;

                

                if (productData.Products[index-1].ProductPrice > coins)
                {
                   Console.Clear();                    
                   Console.WriteLine("Insert {0} kr.", missing);
               
                
                }
                else if (productData.Products[index-1].ProductPrice == coins)
                {
                    Console.Clear();
                    Console.WriteLine("The product will come out in the bottom. \nEnjoy your purchase!");
                    productData.Products[index - 1].ProductStock--;
                    //money.TotalCash += coins;
                    productData.MoneyInMachine += coins;
                   // Console.WriteLine(moneyInMachine);
                    Thread.Sleep(3000);
                    repeat = false;
                }
                else if (productData.Products[index - 1].ProductPrice < coins)
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
