using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            AutomatLogic logic = new AutomatLogic();
            AdminMenu menu = new AdminMenu();
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

                    Console.WriteLine("");
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

                            //bool adminRepeat = true;
                            //int password = 1433;
                            //Console.WriteLine("Enter password");
                            
                            //do
                            //{

                            //    int enteredPassword = int.Parse(Console.ReadLine());

                            //    if (enteredPassword == password)
                            //    {
                            //        //Console.Clear();
                            //        Console.WriteLine("~ Admin menu ~");
                            //        Console.WriteLine("(1) Add new product.");
                            //        Console.WriteLine("(2) Change Products Price.");
                            //        Console.WriteLine("(3) Show Stock On Products.");
                            //        Console.WriteLine("(4) Refill Products.");
                            //        Console.WriteLine("(5) Cash Out.");
                                    
                            //    }
                            //    else
                            //    {
                            //        Console.Clear();
                            //        Console.WriteLine("Access Prohibited.\n");
                            //        Console.WriteLine("Press 1 to try again or 2 to go back to the buyers menu.");
                            //        int adminRepeatInput = int.Parse(Console.ReadLine());
                            //        if (adminRepeatInput != 1)
                            //        {
                            //            adminRepeat = false;
                            //        }
                            //        else if (adminRepeatInput == 2)
                            //        {
                            //            Console.Clear();
                            //            adminRepeat = false;
                                       
                            //        }
                            //    }
                            //} while (adminRepeat == true);
                            

                            break;
                        }
                }
            } 
        }
    }
}
