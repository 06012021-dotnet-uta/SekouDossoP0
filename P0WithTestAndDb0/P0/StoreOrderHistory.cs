using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P0DbContext;

namespace P0
{
    class StoreOrderHistory
    {
        /// <summary>
        /// This will allow the User to see his order history
        /// </summary>
        /// <param name="y"></param>
        public static void OrderHistory(int y)
        {
            P0DBContext context = new P0DBContext();
            var orders = context.Orders.Where(x => x.UserId == y).ToList();
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
}
