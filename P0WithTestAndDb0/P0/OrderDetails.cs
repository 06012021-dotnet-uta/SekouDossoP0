using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P0DbContext;

public class OrderDetails
{
        public static void OrderDetail(int order_id)
        {
            Console.WriteLine("\nOder Details");
            Console.WriteLine("************ Here is your order history *************\n");
            P0DBContext context = new P0DBContext();
            var orders = context.Orders.Where(x => x.OrderId == order_id).ToList();
            if(orders.Count <1) Console.WriteLine("This order doesn't exist.");
            else{
                foreach (var order in orders)
                {
                    var orderProducts = context.OrderProducts.Where(x => x.OrderId == order_id).ToList();
                    foreach (var orderProduct in orderProducts)
                    {
                        var product = context.Products.Where(x => x.ProductId == orderProduct.ProductId).FirstOrDefault();
                        Console.WriteLine($"\norder date    : {orders.FirstOrDefault().OderDate}");
                        // Console.WriteLine($"product       : {product.ProductName} -- {product.ProductDescription} -- price: {product.ProductPrice}$");
                        Console.WriteLine($"product       : {product.ProductName} --product description: {product.ProductDescription} -- price: ${product.ProductPrice}");
                        Console.WriteLine($"quantity sold : {orderProduct.OrderProductQuantity}");
                        Console.WriteLine($"Total Cost    : ${orderProduct.OrderProductQuantity * product.ProductPrice}");
                    }
                }
            }
        }

        /// <summary>
        /// The User id is already send down to the Methods that need it.
        /// but for ferefication the User will be ask to enter his email again.
        /// </summary>
        /// <returns></returns>
        public static void GetOrderId()
        {
            int inputInt = -1;
            bool successfulConversion = false;
            do
            {
                Console.WriteLine("\nPlease enter order Id Number.");
                string input = Console.ReadLine();
                successfulConversion = Int32.TryParse(input, out inputInt);
                //check if the user inputted a number but the numebr is out of bounds.
                if (inputInt < 0)
                    Console.WriteLine($"You inputted {inputInt}, That is not a valid choice.");
                else if (!successfulConversion)
                    Console.WriteLine($"You inputted {inputInt}, That is not a valid choice.");

            } //while (!successfulConversion || (playerChoiceInt < 1 || playerChoiceInt > 3));
            while (!successfulConversion || !(inputInt > 0));
           
            OrderDetail(inputInt);
        }
    
        
    
}