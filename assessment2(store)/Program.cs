using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment2_store_
{
    internal class Program
    {
        //our allow user input options
        public static string[] menuOptions = { "1", "2", "3", "4" };
        public static decimal balance = 0;
        public static string userOption = "";

        private static void CheckPin()
        {
            Console.WriteLine("Welcome to the StoreName. Please enter your name to begin the account making process.");
            string name = Console.ReadLine();
            Console.WriteLine("\nGreat, thanks " + name + ". Now, please enter a pin. It can be any length.");

            //setting the user entered pin
            string pinUser = Console.ReadLine();
            Console.WriteLine("\nYou have successfully made an account.");
            string pin = "";
            Console.WriteLine("\nPlease enter your pin number again to access the store.");

            pin = Console.ReadLine();

            //while loop to check pin
            while (pin != pinUser)
            {
                if (pin == pinUser)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Pin number incorrect, please try again.");
                    pin = Console.ReadLine();
                }
            }

            Console.WriteLine("Pin correct.\n");
            MainMenu();

        } //end CheckPin

        static void MainMenu()
        {
            Console.WriteLine("****************************************\n");
            Console.WriteLine("\t Select an Option:\n");
            Console.WriteLine("\t [1] View Balance");
            Console.WriteLine("\t [2] Deposit Funds");
            Console.WriteLine("\t [3] View Store");
            Console.WriteLine("\t [4] Exit Application\n");
            Console.WriteLine("****************************************\n");

            // run checkinput
            CheckInput();
        }

        public static void CheckInput()
        {
            bool check = false;

            while (check == false)
            {
                Console.WriteLine("Please choose an option ([1], [2], [3], [4])");
                string userInput = Console.ReadLine();

                // loop thru each item in the array (menuOptions) save each interation in the temp variable
                foreach (string temp in menuOptions)
                {
                    // check if users input equals what is in our array (now saved as temp variable)
                    // return true or return false save result into check.
                    check = userInput.Equals(temp);

                    // break out of the foreach loop if check = true
                    if (check)
                    {
                        break;
                    }

                } // end of foreach

                if (check)
                {
                    
                }
                else
                {
                    Console.WriteLine("Your input " + userInput + " is not valid\n\n");
                }

                userOption = userInput;
                ProcessMenu();


            } // end of while loop

        } // end of CheckInput

        static void ProcessMenu()
        {
            decimal amount;

            if (userOption == "1")
            {
                Console.WriteLine("Your balance is " + "$" + balance);
                if (balance <= 0)
                {
                    Console.WriteLine("You need to deposit some money.");
                }
                MainMenu();
            }
            if (userOption == "2")
            {
                Console.WriteLine("Please enter an amount to deposit into your account.");

                if (decimal.TryParse(Console.ReadLine(), out amount))
                {
                    balance += amount;
                    Console.WriteLine("You deposited $" + amount + " Your balance is now $" + balance);
                }
                else
                {
                    Console.WriteLine("Invalid Amount.");
                }
                MainMenu();
            }
            if (userOption == "3")
            {
                Console.WriteLine("Shops here");
            }
            if (userOption == "4")
            {
                Environment.Exit(0);
            }
            MainMenu();
        } // end ProcessMenu

        static void Main(string[] args)
        {
            CheckPin();
        }
    }
}
