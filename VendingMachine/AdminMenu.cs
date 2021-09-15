using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VendingMachine
{
    class AdminMenu
    {
        // This class is the whole admin menu, could have been in the main program, but decided to split the user menu and the admin menu up.
        // This menu class is getting all it's data from the Program class, where AutomatData is instantiated, and is sending it's data back to Program,
        // where there is made a instantiation of this class, using data from AutomatData.
        AutomatData productData;
        AutomatLogic logic;
       // Money money;

        // Constructor
        public AdminMenu(AutomatData data, AutomatLogic logic)
        {
            productData = data;
            this.logic = logic;
        }
        //AutomatLogic logic = new AutomatLogic();


        // Admin menu method
        public void GetAdminMenu() 
        {
            bool adminRepeat = true;
            int password = 1433;

            Console.Clear();
            Console.WriteLine("Enter password");
            int enteredPassword = int.Parse(Console.ReadLine());

            do
            {
                

                if (enteredPassword == password)
                {
                    Console.Clear();
                    Console.WriteLine("~ Admin menu ~");
                    Console.WriteLine("(1) Change Prices.");
                    Console.WriteLine("(2) Show Stock.");
                    Console.WriteLine("(3) Refill Products.");
                    Console.WriteLine("(4) Cash Out.");
                    Console.WriteLine("(0) Go Back To The User Menu");
                    
                    int input = int.Parse(Console.ReadLine());

                    switch (input)
                    {

                        case 1:
                            {
                                // Change prices.
                                bool changePriceRepeat = true;
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Choose which product you want to change the price on.");
                                    foreach (Product product in productData.Products)
                                    {
                                        Console.WriteLine("({0}) {1} ~ {2},- DKK kr.", product.ProductNumber, product.ProductName, product.ProductPrice);

                                    }
                                    Console.WriteLine("Or press 0 to go back to the Admin menu.");
                                    
                                    int productNo = int.Parse(Console.ReadLine());

                                    foreach (Product product in productData.Products)
                                    {

                                        if (productNo == product.ProductNumber)
                                        {
                                            Console.WriteLine($"Insert new price on {product.ProductName}:");
                                            int newPrice = int.Parse(Console.ReadLine());

                                            product.ProductPrice = newPrice;
                                            Console.Clear();
                                            Console.WriteLine($"The new price on {product.ProductName} is now {product.ProductPrice},- DKK kr");

                                            Thread.Sleep(3000);
                                            changePriceRepeat = true;
                                        }   
                                        else if(productNo == 0)
                                        {
                                            changePriceRepeat = false;
                                        }
                                    }


                                    
                                } while (changePriceRepeat == true);
                                break;
                            }
                        case 2:
                            {
                               // Show Stock.
                                foreach (Product product in productData.Products)
                                {
                                    Console.WriteLine("There is {0} {1} left in stock.", product.ProductStock, product.ProductName);
                                }
                                Console.WriteLine("Press Enter to return to the admin menu.");
                                Console.ReadKey();

                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Refill Products.");

                                bool refillProductsRepeat = true;
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Choose which product you want to refill.");
                                    foreach (Product product in productData.Products)
                                    {
                                        Console.WriteLine("({0}) {1} ~ in stock: {2} ", product.ProductNumber, product.ProductName, product.ProductStock);

                                    }
                                    Console.WriteLine("Or press 0 to go back to the Admin menu.");

                                    int productNo = int.Parse(Console.ReadLine());

                                    foreach (Product product in productData.Products)
                                    {

                                        if (productNo == product.ProductNumber)
                                        {
                                            Console.WriteLine($"Insert new stock on {product.ProductName}:");
                                            int refillAmount = int.Parse(Console.ReadLine());

                                            product.ProductStock += refillAmount;
                                            Console.Clear();
                                            Console.WriteLine($"There is now {product.ProductStock} in stock of {product.ProductName}.");

                                            Thread.Sleep(3000);
                                            refillProductsRepeat = true;
                                        }
                                        else if (productNo == 0)
                                        {
                                            refillProductsRepeat = false;
                                        }
                                    }
                                    
                                } while (refillProductsRepeat == true);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine(logic.GetMoneyMachine());
                                Console.WriteLine("Do you want to withdraw the moneys? Press 1 for yes and 2 for no.");
                                int withdrawalInput = int.Parse(Console.ReadLine());
                                if(withdrawalInput == 1)
                                {
                                    logic.SetMoneyMachine(0);
                                    Console.WriteLine($"Moneys in the machine: {logic.GetMoneyMachine()}");
                                }
                                else if( withdrawalInput == 2)
                                {
                                    adminRepeat = true;
                                    
                                }

                                Thread.Sleep(2000);
                                break;
                            }
                        case 0:
                            {
                                adminRepeat = false;
                                break;
                            }
                    }


                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Access Prohibited.\n");
                    Thread.Sleep(1500);
                    adminRepeat = false;
                    
                }
            } while (adminRepeat == true);
        }
        
    }
}
