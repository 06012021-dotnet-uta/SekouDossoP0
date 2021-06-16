using System;
namespace P0
{
    public class Choice
    {
        public enum RegisterOrLogin
        {
            Login = 1,//equivalent to 2
            Register = 2,//equivalent to 1
        }
        // register or login choice
        /// <summary>
        /// First thing the user should do is registeer or login
        /// Get the user decision here then go to register or login
        /// </summary>
        public static void RegisterLogin()
        {
            Console.WriteLine("\nWelcome to Shopping Bay\n");
            Console.WriteLine("Please login or register for new user.");
            int inputInt = -1;
            bool successfulConversion = false;
            do
            {
                Console.WriteLine("1. Login\n2. Register");
                string input = Console.ReadLine();
                successfulConversion = Int32.TryParse(input, out inputInt);
                //check if the user inputted a number but the numebr is out of bounds.
                if (inputInt > 2 || inputInt < 1)
                    Console.WriteLine($"You inputted {inputInt}. That is not a valid choice.");
                else if (!successfulConversion)
                    Console.WriteLine($"You inputted {inputInt}. That is not a valid choice.");

            } //while (!successfulConversion || (playerChoiceInt < 1 || playerChoiceInt > 3));
            while (!successfulConversion || !(inputInt > 0 && inputInt < 3));//both of hte above are valid.
            
            // return inputInt;
            Register.CreateAccount(inputInt);
        }
       


        // store selection or store choice
        /// <summary>
        /// here are the current sotre in my Database
        /// </summary>
        public enum StoreList
        {
            Berluti = 1,//equivalent to 1
            Rolex = 2,//equivalent to 2
            Dsquared2 = 3//equivalent to 3
        }
        /// <summary>
        /// The user will select the store where he want to shop
        /// </summary>
        /// <returns></returns>
        public static int SelectStore()
        {
            Console.WriteLine("Please select a store.");
            int inputInt = -1;
            bool successfulConversion = false;
            do
            {
                Console.WriteLine("1. Berluti\n2. Rolex\n3. Dsquared2");
                string input = Console.ReadLine();
                successfulConversion = Int32.TryParse(input, out inputInt);
                //check if the user inputted a number but the numebr is out of bounds.
                if (inputInt > 3 || inputInt < 1)
                    Console.WriteLine($"You inputted {inputInt}. That is not a valid choice.");
                else if (!successfulConversion)
                    Console.WriteLine($"You inputted {inputInt}. That is not a valid choice.");

            } //while (!successfulConversion || (playerChoiceInt < 1 || playerChoiceInt > 3));
            while (!successfulConversion || !(inputInt > 0 && inputInt < 4));//both of hte above are valid.

            return inputInt;
        }


        // checkout or add new product 
        // store choice
        public enum ShoppingDecision
        {
            exit = 2,//equivalent to 1
            AddProduct = 1,
        }
        /// <summary>
        /// User will add a product to cart or exit shopping process
        /// </summary>
        /// <returns></returns>
        public static int ShoppingOperation()
        {
            Console.WriteLine("\nPlease make a selection.");
            int inputInt = -1;
            bool successfulConversion = false;
            do
            {
                Console.WriteLine("1. addProduct\n2. exit");
                string input = Console.ReadLine();
                successfulConversion = Int32.TryParse(input, out inputInt);
                if (inputInt > 3 || inputInt < 1)
                    Console.WriteLine($"You inputted {inputInt}. That is not a valid choice.");
                else if (!successfulConversion)
                    Console.WriteLine($"You inputted {inputInt}. That is not a valid choice.");
            }
            while (!successfulConversion || !(inputInt > 0 && inputInt < 4));
            return inputInt;

        }

        // main menu 
        public enum MainMenu
        {
            UserOrderHistory = 1,//equivalent to 1
            LocationOrderHistory = 2,//equivalent to 2
            LocationInventory = 3, //equivalent to 3
            StartShopping = 4, //equivalent to 4
            Logout = 5, //equivalent to 5
            SingleOrderDetails = 6,
        }

        /// <summary>
        /// User will have access to this Menu until he logout
        /// when he logout the app will keeps running and 
        /// the next user should login or register
        /// </summary>
        /// <param name="registeredUserId"></param>
        /// <returns></returns>

        public static string Menu(int registeredUserId )
        {
            Console.WriteLine("\nPlease make a selection.");
            int inputInt = -1;
            bool successfulConversion = false;
            do
            {
                Console.WriteLine("\n1. UserOrderHistory\n2. LocationOrderHistory\n3. LocationInventory\n4. StartShopping\n5. Logout\n6. SingleOrderDetails ");
                string input = Console.ReadLine();
                successfulConversion = Int32.TryParse(input, out inputInt);
                if (inputInt > 6 || inputInt < 1)
                    Console.WriteLine($"You inputted {inputInt}. That is not a valid choice.");
                else if (!successfulConversion)
                    Console.WriteLine($"You inputted {inputInt}. That is not a valid choice.");
            }
            while (!successfulConversion || !(inputInt > 0 && inputInt < 7));
            
            SelectMenu.SelectedMenu(inputInt, registeredUserId); 

            return "logout";
        }
    }
}