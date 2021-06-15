using System;
using P0DbContext;
using System.Linq;

namespace P0
{
    public class SelectMenu
    {
        public static void SelectedMenu(int x, int registeredUserId)
        {
            P0DBContext context = new P0DBContext();

            switch (x)
            {
                case 1: // UserOrderHistory = 1
                    // Console.WriteLine("User Order History");
                    // view user order history
                    // Console.WriteLine("\nUser order history");
                    UserOrderHistory.UserOrderHistories();
                    Choice.Menu(registeredUserId);
                    break;
                case 2: // LocationOrderHistory = 2
                    // Console.WriteLine("Location Order History");
                    // view location order history 
                    Console.WriteLine("\nStore Location order history");
                    LocationOrderHistory.locationOrderHistory();
                    Choice.Menu(registeredUserId);
                    break;
                case 3: // LocationInventory = 3
                    Console.WriteLine("Location Inventory");
                    Inventory.LocationInventory();
                    Choice.Menu(registeredUserId);
                    break;
                case 4: // StartShopping = 4
                    Shopping.ShoppingProcess(registeredUserId);
                    Choice.Menu(registeredUserId);

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