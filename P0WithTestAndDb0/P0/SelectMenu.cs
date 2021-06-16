using System;
using P0DbContext;
using System.Linq;

namespace P0
{
    public class SelectMenu
    {
        /// <summary>
        /// Here is the main menu
        /// The User should select unlimited time from this menu until he logout.
        /// Once the user Logout the app will keeps running 
        /// and the next User should login or register to start shopping.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="registeredUserId"></param>
        public static void SelectedMenu(int x, int registeredUserId)
        {
            P0DBContext context = new P0DBContext();

            switch (x)
            {
                case 1: // UserOrderHistory = 1
                    UserOrderHistory.UserOrderHistories();
                    Choice.Menu(registeredUserId);
                    break;
                case 2: // LocationOrderHistory = 2
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
                case 6: // single order details
                    OrderDetails.GetOrderId();
                    Choice.Menu(registeredUserId);
                break;
                // default:
                //     break;
            }
        }
        
    }
}