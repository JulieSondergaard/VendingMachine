using System;
using System.Threading;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomatData data = new AutomatData();
            AutomatLogic logic = new AutomatLogic(data);
            AdminMenu menu = new AdminMenu(data, logic);

            bool automatRepeat = true;

            // Show products and price.
            while (automatRepeat == true)
            {
                Console.Clear();
                Console.WriteLine("Select your product by entering the number of product you want to buy:\n");
                foreach (Product product in logic.GetProductData())
                {
                    if (product.ProductStock == 0)
                    {
                        Console.WriteLine("({0}) {1} ~ Sold Out", product.ProductNumber, product.ProductName);
                    }
                    else
                    {
                        Console.WriteLine("({0}) {1} ~ {2},- DKK kr.", product.ProductNumber, product.ProductName, product.ProductPrice);
                    }  
                }

                
                Console.WriteLine("\nAre you an operator, press #.\n");
                string input = Console.ReadLine();
                int index;

                switch (input)
                {
                    case "1":
                        {
                            index = 1;

                            logic.Payment(index);
                            break;
                        }
                    case "2":
                        {
                            index = 2;
                            logic.Payment(index);
                            break;
                        }
                    case "3":
                        {
                            index = 3;
                            logic.Payment(index);
                            break;
                        }
                    case "4":
                        {
                            index = 4;
                            logic.Payment(index);
                            break;
                        }
                    case "5":
                        {
                            index = 5;
                            logic.Payment(index);
                            break;
                        }
                    case "6":
                        {
                            index = 6;
                            logic.Payment(index);
                            break;
                        }
                    case "#":
                        {
                            menu.GetAdminMenu();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("You entered a product that doesn't exist.");
                            Thread.Sleep(3000);
                            automatRepeat = true;
                            break;
                        }
                }
            } 
        }
    }
}
