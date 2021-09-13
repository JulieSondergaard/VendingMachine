using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            AutomatLogic logic = new AutomatLogic();
            bool repeat = true;

            Console.WriteLine("~Vending Machine~\n");

            // Show products and price.
            do
            {
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

                Console.WriteLine("Choose your product");
                Console.WriteLine("Are you an operator, press #.\n");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        {

                            break;
                        }
                    case "2":
                        {

                            break;
                        }
                    case "3":
                        {

                            break;
                        }
                    case "4":
                        {

                            break;
                        }
                    case "5":
                        {

                            break;
                        }
                    case "6":
                        {

                            break;
                        }
                    case "#":
                        {
                            int password = 1433;
                            Console.Clear();
                            Console.WriteLine("Enter password");
                            int enteredPassword = int.Parse(Console.ReadLine());

                            if (enteredPassword == password)
                            {
                                Console.Clear();
                                Console.WriteLine("~ Admin menu ~");
                                Console.WriteLine("(1) Add new product.");
                                Console.WriteLine("(2) Change Products Price.");
                                Console.WriteLine("(3) Show Stock On Products.");
                                Console.WriteLine("(4) Refill Products.");
                                Console.WriteLine("(5) Cash Out.");
                                repeat = false;
                            }
                            else
                            {
                                bool adminRepeat = true;
                                do
                                {
                                    Console.WriteLine("Access Prohibited.");
                                    Console.WriteLine("Press 1 to go back to the menu.");
                                    int adminRepeatInput = int.Parse(Console.ReadLine());
                                    if (adminRepeatInput == 1)
                                    {
                                        adminRepeat = false;
                                    }
                                 
                                } while (adminRepeat == true);
                            }

                            break;
                        }

                }
            } while (repeat == true);
        }
    }
}
