using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class AdminMenu
    {
        public void GetAdminMenu() 
        {
            bool adminRepeat = true;
            int password = 1433;
            Console.Clear();
            Console.WriteLine("Enter password");
            do
            {
                

            

                int enteredPassword = int.Parse(Console.ReadLine());

                if (enteredPassword == password)
                {
                    //Console.Clear();
                    Console.WriteLine("~ Admin menu ~");
                    Console.WriteLine("(1) Add new product.");
                    Console.WriteLine("(2) Change Products Price.");
                    Console.WriteLine("(3) Show Stock On Products.");
                    Console.WriteLine("(4) Refill Products.");
                    Console.WriteLine("(5) Cash Out.");

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Access Prohibited.\n");
                    Console.WriteLine("Press 1 to try again or 2 to go back to the buyers menu.");
                    int adminRepeatInput = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Enter password");
                    if (adminRepeatInput != 1 || adminRepeatInput == 2)
                    {
                        
                        adminRepeat = false;
                    }
                    
                }
            } while (adminRepeat == true);
        }
        
    }
}
