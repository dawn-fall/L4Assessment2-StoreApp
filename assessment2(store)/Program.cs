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
        public static string[] menuOptions = { "1", "2", "3", "4", "5", "6" };
        public static decimal balance = 0;
        public static string userOption = "";

        private static void StartCheckPin()
        {
            Console.WriteLine("Welcome to the Computer Store account maker. Please enter your name to begin the account making process.");
            string name = Console.ReadLine();
            Console.WriteLine("\nGreat, thanks " + name + ". Now, please enter a pin or password. It can be any length.");

            //setting the user entered pin
            string pinUser = Console.ReadLine();
            Console.WriteLine("\nYou have successfully made an account.");
            string pin = "";
            Console.WriteLine("\nPlease enter your pin number again to access the store.");

            pin = Console.ReadLine();

            //while loop to check pin matches
            while (pin != pinUser)
            {
                if (pin == pinUser)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nPin number incorrect, please try again.");
                    pin = Console.ReadLine();
                }
            }

            Console.WriteLine("\nPin correct.\n");
            MainMenu();

        } //end CheckPin

        static void MainMenu()
        {
            Console.WriteLine("****************************************\n");
            Console.WriteLine("\t Welcome to The Computer Store.\n");
            Console.WriteLine("\t Select an Option:\n");
            Console.WriteLine("\t [1] View Balance");
            Console.WriteLine("\t [2] Deposit Funds");
            Console.WriteLine("\t [3] View Store");
            Console.WriteLine("\t [4] Exit Application\n");
            Console.WriteLine("****************************************\n");
            Console.WriteLine("Please choose an option ([1], [2], [3], [4])");

            // run checkinput
            CheckInput();
        }

        static void CheckInput()
        {
            bool check = false;

            while (check == false)
            {
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
                Console.WriteLine("\nYour balance is " + "$" + balance + ".\n");
                if (balance <= 0)
                {
                    Console.WriteLine("\nYou need to deposit some money.\n");
                }
                MainMenu();
            }
            if (userOption == "2")
            {
                Console.WriteLine("\nPlease enter an amount to deposit into your account.");

                if (decimal.TryParse(Console.ReadLine(), out amount))
                {
                    balance += amount;
                    Console.WriteLine("\nYou deposited $" + amount + ". Your balance is now $" + balance + ".\n");
                }
                else
                {
                    Console.WriteLine("Invalid Amount.");
                }
                MainMenu();
            }
            if (userOption == "3")
            {
                option3();
            }
            if (userOption == "4")
            {
                Environment.Exit(0);
            }
            MainMenu();
        } // end ProcessMenu

        public static void option3()
        {
            Console.WriteLine("\n****************************************\n");
            Console.WriteLine("\t Select a category to view:\n");
            Console.WriteLine("\t [1] View CPU Options");
            Console.WriteLine("\t [2] View GPU Options");
            Console.WriteLine("\t [3] View RAM Options");
            Console.WriteLine("\t [4] View Motherboard Options");
            Console.WriteLine("\t [5] View Case Options");
            Console.WriteLine("\t [6] Exit to Main Menu\n");
            Console.WriteLine("****************************************\n");
            Console.WriteLine("Please choose an option ([1], [2], [3], [4], [5], [6])");

            CheckInputStore();
        }

        static void CheckInputStore()
        {
            bool check = false;

            while (check == false)
            {
                string userInput = Console.ReadLine();
                foreach (string temp in menuOptions)
                {
                    check = userInput.Equals(temp);

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
                storeMenu();


            } // end of while loop

        } // end of CheckInputStore

        public static void storeMenu()
        {
            if (userOption == "1")
            {
                CategoryOne();
            }
            if (userOption == "2")
            {
                CategoryTwo();
            }
            if (userOption == "3")
            {
                CategoryThree();
            }
            if (userOption == "4")
            {
                CategoryFour();
            }
            if (userOption == "5")
            {
                CategoryFive();
            }
            if (userOption == "6")
            {
                MainMenu();
            }

        }//end storeMenu

        static void CategoryOne()
        {
            Console.WriteLine("\n****************************************\n");
            Console.WriteLine("\t Select an item to view:\n");
            Console.WriteLine("\t [1] Ryzen 5 5600x");
            Console.WriteLine("\t [2] Ryzen 7 5700x");
            Console.WriteLine("\t [3] Ryzen 9 5900x");
            Console.WriteLine("\t [4] Intel i5-12400F");
            Console.WriteLine("\t [5] Intel i7-12700K");
            Console.WriteLine("\t [6] Exit to Catergory Selection\n");
            Console.WriteLine("****************************************\n");

            CheckInputItem();

        }//end catONE CPU

        static void CategoryTwo()
        {
            Console.WriteLine("\n****************************************\n");
            Console.WriteLine("\t Select an item to view:\n");
            Console.WriteLine("\t [1] Gigabyte GeForce RTX 3060");
            Console.WriteLine("\t [2] EVGA GeForce RTX 3070 Ti");
            Console.WriteLine("\t [3] EVGA GeForce RTX 3080");
            Console.WriteLine("\t [4] Powercolor Hellhound RX6700 XT");
            Console.WriteLine("\t [5] Powercolor Red Devil RX 6900 XT");
            Console.WriteLine("\t [6] Exit to Catergory Selection\n");
            Console.WriteLine("****************************************\n");

            CheckInputItem();

        }//end catTWO GPU

        static void CategoryThree()
        {
            Console.WriteLine("\n****************************************\n");
            Console.WriteLine("\t Select an item to view:\n");
            Console.WriteLine("\t [1] G.SKILL Ripjaws V Series 16GB");
            Console.WriteLine("\t [2] G.SKILL Ripjaws V Series 32GB");
            Console.WriteLine("\t [3] Corsair Vengeance RGB 16GB");
            Console.WriteLine("\t [4] Kingston FURY Beast 16GB");
            Console.WriteLine("\t [5] Crucial 16GB");
            Console.WriteLine("\t [6] Exit to Catergory Selection\n");
            Console.WriteLine("****************************************\n");

            CheckInputItem();

        }//end catTHREE RAM

        static void CategoryFour()
        {
            Console.WriteLine("\n****************************************\n");
            Console.WriteLine("\t Select an item to view:\n");
            Console.WriteLine("\t [1] Gigabyte B550M mATX");
            Console.WriteLine("\t [2] ASUS ROG STRIX B550-A Gaming ATX");
            Console.WriteLine("\t [3] MSI MAG B550M PRO mATX");
            Console.WriteLine("\t [4] ASUS PRIME B660-PLUS ATX");
            Console.WriteLine("\t [5] MSI B560M PRO-E mATX");
            Console.WriteLine("\t [6] Exit to Catergory Selection\n");
            Console.WriteLine("****************************************\n");

            CheckInputItem();

        }//end catFOUR MOTHERBOARDS

        static void CategoryFive()
        {
            Console.WriteLine("\n****************************************\n");
            Console.WriteLine("\t Select an item to view:\n");
            Console.WriteLine("\t [1] DEEPCOOL MATREXX 55 (Black)");
            Console.WriteLine("\t [2] Phanteks Eclipse P360A (White)");
            Console.WriteLine("\t [3] Corsair 4000D Airflow (Black)");
            Console.WriteLine("\t [4] Lian Li Lancool 215 (Black)");
            Console.WriteLine("\t [5] NZXT H511 Compact (Matte White)");
            Console.WriteLine("\t [6] Exit to Catergory Selection\n");
            Console.WriteLine("****************************************\n");

            CheckInputItem();

        }//end catFIVE CASES

        public static void CheckInputItem()
        {
            bool check = false;

            while (check == false)
            {
                string userInput = Console.ReadLine();
                foreach (string temp in menuOptions)
                {
                    check = userInput.Equals(temp);

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
                processItems();
            }
        }//end item check input

        public static void processItems()
        {

        }//end process items

        static void Main(string[] args)
        {
            StartCheckPin();
        }//dont delete the main again, end
    }
}
