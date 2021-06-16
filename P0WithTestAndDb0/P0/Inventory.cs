using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P0DbContext;

namespace P0
{
    class Inventory
    {
        /// <summary>
        /// Select a location to see it's inventory
        /// </summary>
        public static void LocationInventory()
        {
            Console.WriteLine("\nFor inventory please select a location from ");
            int location = LocationOrderHistory.SelectLocation();
            
            P0DBContext context = new P0DBContext();
            var LName = context.Locations.Where(x => x.LocationId == location).FirstOrDefault().LocationName;
            Console.WriteLine($"{LName} inventory: ");
            var stores = context.Stores.Where(x => x.LocationId == location).ToList();
            foreach (var store in stores)
            {
                var storeProducts = context.StoreProducts.Where(x => x.StoreId == store.StoreId).ToList();
                foreach (var storeProduct in storeProducts)
                {
                    var products = context.Products.Where(x => x.ProductId == storeProduct.StoreProductId).ToList();
                    foreach(var p in products)
                    {
                        Console.WriteLine($"productName: {p.ProductName}  quantity: {storeProduct.StoreProductQuantity} Store: {store.StoreName}");
                    }
                }
            }
        }
    }
}
