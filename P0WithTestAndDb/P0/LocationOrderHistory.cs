using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P0DbContext;

namespace P0
{
    class LocationOrderHistory
    {
        public static void locationOrderHistory()
        {
            int y = SelectLocation();
            P0DBContext context = new P0DBContext();
            var orders = context.Orders.Where(x => x.LocationId == y).ToList();
            if (orders.Count < 1) Console.WriteLine("This location have no order history.");
            else
            {
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
        }// end OrderHistory

        public static int SelectLocation()
        {
            Console.WriteLine("Locations list.\n");
            P0DBContext context = new P0DBContext();
            var locations = context.Locations.ToList();
            foreach (var location in locations) Console.WriteLine($" {location.LocationName}");

            string selectedLocation = "";
            int checkedLocation = -1;
            do
            {
                do
                {
                    Console.WriteLine("Please select a location.");
                    selectedLocation = Console.ReadLine();
                    if (selectedLocation.Length < 1) Console.WriteLine(" lacotion name must be atleast 1 character.\n Please select from the list above. ");
                }
                while (selectedLocation.Length < 1);
                checkedLocation = locations.Where(x => x.LocationName == selectedLocation).Count();
                if (checkedLocation < 1) Console.Write("Please select from locations list above.\n");
            } while (checkedLocation < 1);
            int checkedLocationId = locations.Where(x => x.LocationName == selectedLocation).FirstOrDefault().LocationId;
            return checkedLocationId;
        }     
    }  
}
