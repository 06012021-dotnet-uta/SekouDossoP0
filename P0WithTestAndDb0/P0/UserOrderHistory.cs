using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P0DbContext;

namespace P0
{
    class UserOrderHistory
    {
        public static void UserOrderHistories()
        {
            Console.WriteLine("\nUser order history");
            int user_id = UserInfo();
            Console.WriteLine("************ Here is your order history *************\n");
            P0DBContext context = new P0DBContext();
            var orders = context.Orders.Where(x => x.UserId == user_id).ToList();
            if(orders.Count <1) Console.WriteLine("You have no order history.");
            else{
                foreach (var order in orders)
                {
                    var orderProducts = context.OrderProducts.Where(x => x.OrderId == order.OrderId).ToList();
                    foreach (var orderProduct in orderProducts)
                    {
                        var product = context.Products.Where(x => x.ProductId == orderProduct.OrderId).FirstOrDefault();
                        Console.WriteLine($"order date : {order.OderDate}");
                        Console.WriteLine($"product    : {product.ProductName} -- {product.ProductDescription} -- price: {product.ProductPrice}$");
                    }
                }
            }
        }
        public static int UserInfo()
        {
           P0DBContext context = new P0DBContext();
            string email = "";
            int result = -1;
            do
            {
                Console.WriteLine("Please enter your email for verification: ");
                email = Console.ReadLine();
                result = context.Users.ToList().Where(x => x.Email == email).Count();
                if (result < 1) Console.WriteLine($"Wrong email.");
            } while (result < 1);

            int user_id = context.Users.ToList().Where(x => x.Email == email).FirstOrDefault().UserId;
            return user_id;
        }
    }


}
