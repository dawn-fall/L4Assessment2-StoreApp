using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment2_store_
{
    internal class Program
    {
        //global Variables
        //allowed user input options for menus
        public static string[] menuOptions = { "1", "2", "3", "4", "5", "6" };

        //user balance automatically set to 0
        public static decimal balance = 0;

        public static string[] buyChoice = { "y", "n" };

        //strings for user input
        public static string userOption = "";
        public static string userOptionStore = "";
        public static string userOptionItem = "";
        public static string choice = "";

        private static void StartCheckPin()
        {
            //beginning of code store
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
            //code for main menu
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
                    //do nothing
                }
                else
                {
                    //tell them their input is wrong
                    Console.WriteLine("Your input " + userInput + " is not valid");
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
                if (balance <= 0)
                {
                    //tell them that they have no money, redirect to main menu
                    Console.WriteLine("\nYou need to deposit some money. Press enter to go back to the Main Menu.\n");
                    Console.ReadKey();
                    MainMenu();
                }
                if (balance > 0)
                {
                    //show current balance, redirect to main menu
                    Console.WriteLine("\nYour balance is " + "$" + balance + ". Press enter to go back to the Main Menu.\n");
                    Console.ReadKey();
                    MainMenu();
                }
            }
            if (userOption == "2")
            {
                Console.WriteLine("\nPlease enter an amount to deposit into your account.");

                if (decimal.TryParse(Console.ReadLine(), out amount))
                {
                    //deposit the amount of money that the user selects, redirect to main menu
                    balance += amount;
                    Console.WriteLine("\nYou deposited $" + amount + ". Your balance is now $" + balance + ". Press enter to go back to the Main Menu.\n");
                    Console.ReadKey();
                }
                else
                {
                    //tell user the amount was invalid
                    Console.WriteLine("Invalid Amount.");
                }
                MainMenu();
            }
            if (userOption == "3")
            {
                //call function for category menu
                option3();
            }
            if (userOption == "4")
            {
                //exit
                Environment.Exit(0);
            }
        } // end ProcessMenu

        public static void option3()
        {
            //category menu view
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

            //call check input for category select
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
                    Console.WriteLine("Your input " + userInput + " is not valid");
                }

                userOptionStore = userInput;
                storeMenu();


            } // end of while loop

        } // end of CheckInputStore

        public static void storeMenu()
        {
            if (userOptionStore == "1")
            {
                CategoryOne();
            }
            if (userOptionStore == "2")
            {
                CategoryTwo();
            }
            if (userOptionStore == "3")
            {
                CategoryThree();
            }
            if (userOptionStore == "4")
            {
                CategoryFour();
            }
            if (userOptionStore == "5")
            {
                CategoryFive();
            }
            if (userOptionStore == "6")
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
            Console.WriteLine("Please choose an option ([1], [2], [3], [4], [5], [6])");

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
            Console.WriteLine("Please choose an option ([1], [2], [3], [4], [5], [6])");

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
            Console.WriteLine("Please choose an option ([1], [2], [3], [4], [5], [6])");

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
            Console.WriteLine("Please choose an option ([1], [2], [3], [4], [5], [6])");

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
            Console.WriteLine("Please choose an option ([1], [2], [3], [4], [5], [6])");

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
                    Console.WriteLine("Your input " + userInput + " is not valid");
                }

                userOptionItem = userInput;
                processItems();
            }
        }//end item check input

        public static void processItems()
        {
            if(userOptionStore == "1")
            {
                if(userOptionItem == "1")
                {
                    Console.WriteLine("\nRyzen 5 5600x for $385");
                    Console.WriteLine("Specifications:");
                    //give production information
                    Console.WriteLine("-6 Cores, 12 Threads\n-Up to 4.6GHz clock speed\n-Socket AM4");

                    //gives option to buy or not to buy
                    Console.WriteLine("\nDo you wish to purchase this item for $385?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        //creates variable for purchase amount (preset)
                        decimal purchase = 385;
                        //subtracts purchase from original balance and saves new number to the balance variable
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 385)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            //shows new balance
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 385)
                        {
                            //if funds arent sufficient, redirect to category selection
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        //redirects to category selection
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "2")
                {
                    Console.WriteLine("\n[2] Ryzen 7 5700x for $470");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-8 Cores, 16 Threads\n-Up to 4.6GHz clock speed\n-Socket AM4");

                    Console.WriteLine("\nDo you wish to purchase this item for $470?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 470;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 470)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 470)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "3")
                {
                    Console.WriteLine("\n[3] Ryzen 9 5900x for $650");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-12 Cores, 24 Threads\n-Up to 4.8GHz\n-Socket AM4");

                    Console.WriteLine("\nDo you wish to purchase this item for $650?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 650;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 650)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 650)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "4")
                {
                    Console.WriteLine("\nIntel i5-12400F for $290");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-6 Cores, 12 Threads\n-Up to 4.4GHz clock speed\n-Socket LGA1700");

                    Console.WriteLine("\nDo you wish to purchase this item for $290?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 290;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 290)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 290)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "5")
                {
                    Console.WriteLine("\nIntel i7-12700K for $660");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-12 Cores, 20 Threads\n-Up to 5.0GHz clock speed\n-Socket LGA1700");

                    Console.WriteLine("\nDo you wish to purchase this item for $660?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 660;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 660)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 660)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
            }
            if (userOptionStore == "2")
            {
                if (userOptionItem == "1")
                {
                    Console.WriteLine("\nGigabyte GeForce RTX 3060 for $750");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-12 GB GDDR6 Memory\n-1837MHz maximum clock speed\n-Maximum four displays");

                    Console.WriteLine("\nDo you wish to purchase this item for $750?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 750;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 750)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 750)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "2")
                {
                    Console.WriteLine("\nEVGA GeForce RTX 3070 Ti for $1300");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-8 GB GDDR6x Memory\n-1860MHz maximum clock speed\n-Maximum four displays");

                    Console.WriteLine("\nDo you wish to purchase this item for $1300?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 1300;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 1300)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 1300)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "3")
                {
                    Console.WriteLine("\nEVGA GeForce RTX 3080 $1500");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-10 GB GDDR6x Memory\n-1800MHz maximum clock speed\n-Maximum four displays");

                    Console.WriteLine("\nDo you wish to purchase this item for $1500?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 1500;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 1500)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 1500)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "4")
                {
                    Console.WriteLine("\nPowercolor Hellhound RX6700 XT for $900");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-12 GB GDDR6 Memory\n-2581MHz maximum clock speed\n-Maximum four displays");

                    Console.WriteLine("\nDo you wish to purchase this item for $900?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 900;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 900)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 900)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "5")
                {
                    Console.WriteLine("\nPowercolor Red Devil RX 6900 XT $1800");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-16 GB GDDR6 Memory\n-2340MHz maximum clock speed\n-Maximum four displays");

                    Console.WriteLine("\nDo you wish to purchase this item for $1800?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 1800;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 1800)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 1800)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
            }
            if (userOptionStore == "3")
            {
                if (userOptionItem == "1")
                {
                    Console.WriteLine("\nG.SKILL Ripjaws V Series 16GB for $135");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-2x8GB DIMMS\n-DDR4\n-3200MHz speed");

                    Console.WriteLine("\nDo you wish to purchase this item for $135?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 135;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 135)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 135)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "2")
                {
                    Console.WriteLine("\nG.SKILL Ripjaws V Series 32GB $260");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-2x16GB DIMMS\n-DDR4\n-3600MHz speed");

                    Console.WriteLine("\nDo you wish to purchase this item for $260?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 260;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 260)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 260)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "3")
                {
                    Console.WriteLine("\nCorsair Vengeance RGB 16GB for $140");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-2x8GB DIMMS\n-DDR4\n-3600MHz speed");

                    Console.WriteLine("\nDo you wish to purchase this item for $140?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 140;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 140)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 140)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "4")
                {
                    Console.WriteLine("\nKingston FURY Beast 16GB for $140");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-2x8GB DIMMS\n-DDR4\n-3200MHz speed");

                    Console.WriteLine("\nDo you wish to purchase this item for $140?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 140;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 140)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 140)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "5")
                {
                    Console.WriteLine("\nCrucial 16GB for $100");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-1x16GB DIMM\n-DDR4\n-2660MHz speed\n-Unbuffed");

                    Console.WriteLine("\nDo you wish to purchase this item for $100?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 100;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 100)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 100)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
            }
            if (userOptionStore == "4")
            {
                if (userOptionItem == "1")
                {
                    Console.WriteLine("\nGigabyte B550M mATX for $200");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-mATX Form Factor\n-Socket AM4 Compatible\n-4x DDR4 DIMM Sockets\n-Bluetooth 4.2 + WiFi\n-8x USB back IO\n-2x 12V RGB Headers, 2x 5V A-RGB Headers, 2x PCIe x16");

                    Console.WriteLine("\nDo you wish to purchase this item for $200?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 200;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 200)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 200)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "2")
                {
                    Console.WriteLine("\nASUS ROG STRIX B550-A Gaming ATX for $280");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-ATX Form Factor\n-Socket AM4 Compatible\n-4x DDR4 DIMM Sockets\n-7x USB back IO\n-2x 12V RGB Headers, 1x 5V A-RGB Headers, 2x PCIe x16 Crossfire Compatible");

                    Console.WriteLine("\nDo you wish to purchase this item for $280?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 280;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 280)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 280)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "3")
                {
                    Console.WriteLine("\nMSI MAG B550M PRO mATX for $205");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-mATX Form Factor\n-Socket AM4 Compatible\n-4x DDR4 DIMM Sockets\n-Bluetooth + WiFi\n-6x USB back IO\n-2x 12V RGB Headers, 1x PCIe x16");

                    Console.WriteLine("\nDo you wish to purchase this item for $205?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 205;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 205)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 205)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "4")
                {
                    Console.WriteLine("\nASUS PRIME B660-PLUS ATX for $280");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-ATX Form Factor\n-Socket LGA1700 Compatible\n-4x DDR4 DIMM Sockets\n-5x USB, 1x USB-C back IO\n-2x 12V RGB Headers, 3x 5V A-RGB Headers, 2x PCIe x16");

                    Console.WriteLine("\nDo you wish to purchase this item for $280?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 280;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 280)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 280)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "5")
                {
                    Console.WriteLine("\nMSI B560M PRO-E mATX for $140");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-mATX Form Factor\n-Socket LGA1200 Compatible\n-2x DDR4 DIMM Sockets\n-6x USB back IO\n-1x PCIe x16");

                    Console.WriteLine("\nDo you wish to purchase this item for $140?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 140;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 140)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 140)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
            }
            if (userOptionStore == "5")
            {
                if (userOptionItem == "1")
                {
                    Console.WriteLine("\nDEEPCOOL MATREXX 55 (Black) for $130");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-Mid Tower\n-Maximum GPU Card Length: 370mm\n-360mm Radiator support\n-4x 2.5 drive bays, 2x 2.5/3.5 drive bays\n-3x Front USB\n-4x Addressable Fans");

                    Console.WriteLine("\nDo you wish to purchase this item for $130?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 130;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 130)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 130)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "2")
                {
                    Console.WriteLine("\nPhanteks Eclipse P360A (White) for $150");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-Mid Tower\n-Maximum GPU Card Length: 400mm\n-280mm Radiator support\n-3x 2.5 drive bays, 2x 2.5/3.5 drive bays\n-2x Front USB\n-2x 120mm D-RGB Front Fans");

                    Console.WriteLine("\nDo you wish to purchase this item for $150?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 150;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 150)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 150)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "3")
                {
                    Console.WriteLine("\nCorsair 4000D Airflow (Black) for $155");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-Mid Tower\n-Maximum GPU Card Length: 360mm\n-360mm Radiator support\n-2x 2.5 drive bays, 2x 2.5/3.5 drive bays\n-1x Front USB, 1x Front USB-C");

                    Console.WriteLine("\nDo you wish to purchase this item for $155?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 155;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 155)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 155)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "4")
                {
                    Console.WriteLine("\nLian Li Lancool 215 (Black) for $130");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-Mid Tower\n-Maximum GPU Card Length: 370mm\n-360mm Radiator support\n-2x 2.5 drive bays, 2x 2.5/3.5 drive bays\n-2x Front USB");

                    Console.WriteLine("\nDo you wish to purchase this item for $130?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 130;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 130)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 130)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
                if (userOptionItem == "5")
                {
                    Console.WriteLine("\nNZXT H511 Compact (Matte White) for $150");
                    Console.WriteLine("Specifications:");
                    Console.WriteLine("-Mid Tower\n-Maximum GPU Card Length: 381mm\n-360mm Radiator support\n-3x 2.5 drive bays, 6x 2.5/3.5 drive bays\n-2x Front USB 3.0");

                    Console.WriteLine("\nDo you wish to purchase this item for $150? y/n?");
                    CheckInputBuy();
                    if (choice == "y")
                    {
                        decimal purchase = 150;
                        balance = Decimal.Subtract(balance, purchase);
                        if (balance > 150)
                        {
                            Console.WriteLine("\nYou have purchased this item.");
                            Console.WriteLine("Your balance is now $" + balance);
                            Console.WriteLine("Press enter to return to main menu.\n");
                            Console.ReadKey();
                            MainMenu();
                        }
                        if (balance == 0 || balance < 150)
                        {
                            Console.WriteLine("\nYou do not have the sufficient funds.");
                            Console.WriteLine("Press enter to go back to the Category Select Menu");
                            Console.ReadLine();
                            option3();
                        }
                    }
                    if (choice == "n")
                    {
                        Console.WriteLine("Press enter to go back to the Category Select Menu.");
                        Console.ReadLine();
                        option3();
                    }
                }
            }
            if (userOptionItem == "6")
            {
                option3();
            }

        }//end process items

        public static void CheckInputBuy()
        {
            bool check = false;

            while (check == false)
            {
                string userInput = Console.ReadLine();
                foreach (string temp in buyChoice)
                {
                    check = userInput.Equals(temp);

                    if (check)
                    {
                        choice = userInput;
                        break;
                    }

                } // end of foreach

                if (check)
                {

                }
                else
                {
                    Console.WriteLine("Your input " + userInput + " is not valid");
                }
            }
        }//end item check input


        static void Main(string[] args)
        {
            StartCheckPin();
        }//end
    }
}
