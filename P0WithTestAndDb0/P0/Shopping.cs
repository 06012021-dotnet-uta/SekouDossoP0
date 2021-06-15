
using System;
using P0DbContext;
using System.Linq;
namespace P0
{
    public class Shopping
    {
        public static void ShoppingProcess(int registeredUserId){
            P0DBContext context = new P0DBContext();
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
                    string input = "";//
                    var product = context.Products.ToList().FirstOrDefault();
                    do{
                        Console.WriteLine($"Please Enter the excate name of a product.\n");
                        input = Console.ReadLine();
                        product = context.Products.Where(x => x.ProductName == input).FirstOrDefault();
                    }while( product.ProductName != input);
                            
                    int quantity = OQuantity();
                                // before checkout out check if product quantity in enough 
                    int proQuantity = context.StoreProducts.Where(x => x.StoreProductId == product.ProductId).FirstOrDefault().StoreProductQuantity;
                    if(quantity <= proQuantity)
                    {  // checkout
                                // create order
                                var newOrder = new P0DbContext.Order();
                                newOrder.UserId = registeredUserId;
                                newOrder.LocationId = selection;
                                newOrder.OderDate = DateTime.Today;
                                context.Add(newOrder); context.SaveChanges();
                                Console.WriteLine("New order was accepted");
                                // create OrderProduct                                   
                                var newOrderProduct = new P0DbContext.OrderProduct();
                                newOrderProduct.ProductId = product.ProductId;
                                newOrderProduct.OrderId = context.Orders.ToList().LastOrDefault().OrderId;                               
                                newOrderProduct.OrderProductQuantity = quantity;
                                context.Add(newOrderProduct); 
                                context.SaveChanges();
                                Console.WriteLine("New order has been recorded.");
                                // update StoreProduct quantity
                                var storeProduct = context.StoreProducts.SingleOrDefault(x => x.ProductId == product.ProductId);
                                if(storeProduct != null){
                                    Console.WriteLine($"quantity in stock {storeProduct.StoreProductQuantity}");
                                    storeProduct.StoreProductQuantity = (proQuantity - quantity) ;
                                    context.SaveChanges();
                                    Console.WriteLine("The product stock has been updated.");
                                }
                                else Console.WriteLine("Product not found.");
                    }
                    else {
                                    Console.WriteLine(" This Product has a low stock.");
                    }
                Choice.Menu(registeredUserId);
                break;
                case 2: // exit
                        Choice.Menu(registeredUserId);
                break;        
            }
        }
        


        public static int OQuantity( )
        {
            Console.WriteLine($"Please Enter the quantity of product.\n");
            int inputInt = -1;
            bool successfulConversion = false;
            do
            {
                string input = Console.ReadLine();
                successfulConversion = Int32.TryParse(input, out inputInt);
                if (inputInt < 1)
                    Console.WriteLine($"You inputted {inputInt}. That is not a valid choice.");
                else if (!successfulConversion)
                    Console.WriteLine($"You inputted {inputInt}. That is not a valid choice.");
            }
            while (!successfulConversion || !(inputInt > 0));
            

            return inputInt;
        }
    }
}
