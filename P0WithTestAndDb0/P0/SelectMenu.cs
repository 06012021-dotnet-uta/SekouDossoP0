using System;
namespace P0
{
    public class SelectMenu
    {
        public static void SelectedMenu(int x)
        {
            
            switch (x)
            {
                case 1: // UserOrderHistory = 1
                    // Console.WriteLine("User Order History");
                    // view user order history
                    // Console.WriteLine("\nUser order history");
                    UserOrderHistory.UserOrderHistories();
                    Choice.Menu();
                    break;
                case 2: // LocationOrderHistory = 2
                    // Console.WriteLine("Location Order History");
                    // view location order history 
                    Console.WriteLine("\nStore Location order history");
                    LocationOrderHistory.locationOrderHistory();
                    Choice.Menu();
                    break;
                case 3: // LocationInventory = 3
                    Console.WriteLine("Location Inventory");
                    Inventory.LocationInventory();
                    Choice.Menu();
                    break;
                case 4: // StartShopping = 4
                 // select a store 
                    // Console.WriteLine("Please Select a store. ");
                    var selection = Choice.SelectStore();
                    Console.WriteLine($"Welcom to {(Choice.StoreList)selection} store.\n");
                    // display store's products
                    DisplayProducts.Display(selection);
                    //Console.WriteLine($"Please start your shopping, Enter the excate name of a product.\n");
                    //Console.WriteLine("Select a product");
                    //Console.WriteLine("Enter the quantity");
                    Choice.Menu();

                    break;
                case 5: // Logout = 5
                    Console.WriteLine("Bye bye");
                    Choice.RegisterLogin(); // select register or login
                    break;
                // default:
                //     break;
            }
        }
        
    }
}