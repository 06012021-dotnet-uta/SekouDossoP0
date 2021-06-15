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
                    Cart cart = new Cart();
                 // select a store 
                    // Console.WriteLine("Please Select a store. ");
                    var selection = Choice.SelectStore();
                    Console.WriteLine($"Welcom to {(Choice.StoreList)selection} store.\n");
                    // display store's products
                    DisplayProducts.Display(selection);
                    int dicision = Choice.ShoppingOperation();

                    switch(dicision)
                    {
                        case 1: // add product
                            Console.WriteLine($"Please Enter the excate name of a product.\n");
                            string input = Console.ReadLine();
                            var product = context.Products.Where(x => x.ProductName == input).FirstOrDefault();
                            if(product.ProductName != input) Console.WriteLine("Please enter the exact name of a product.");
                            else {
                                Console.WriteLine($"Please Enter the quantity of product.\n");
                                input = Console.ReadLine();
                                int quantity = Int32.Parse(input);
                                cart.AddProduct(new Product(product.ProductName));
                                // checkout
                                var newOrder = new P0DbContext.Order();
                                newOrder.UserId = registeredUserId;
                                newOrder.LocationId = selection;
                                newOrder.OderDate = DateTime.Today;
                                context.Add(newOrder);
                                context.SaveChanges();

                                var newOrderProduct = new P0DbContext.OrderProduct();
                                newOrderProduct.ProductId = product.ProductId;
                                newOrderProduct.OrderId = context.Orders.ToList().LastOrDefault().OrderId;                               
                                newOrderProduct.OrderProductQuantity = quantity;
                                //newUser = MapperClassAppToDb.AppUserToDbUser(newUser);
                                context.Add(newOrderProduct); 
                                context.SaveChanges();
                                Choice.Menu(registeredUserId);
                            }
                        break;
                        case 2: // exit
                            Choice.Menu(registeredUserId);
                        break;
                        
                    }
                    //Console.WriteLine("Select a product");
                    //Console.WriteLine("Enter the quantity");
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