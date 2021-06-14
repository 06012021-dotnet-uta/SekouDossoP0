using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using P0DbContext;

namespace P0
{
    class DisplayProducts
    {

        public static void Display(int y)
        {
            // var currentUser = db.Users
            //       .Where(x => x.FisrtName == "Sekou");
            //    Console.WriteLine($"the current user is : {currentUser.FirstOrDefault().FisrtName}");
            P0DBContext context = new P0DBContext();
            var storeProducts = context.StoreProducts.Where(x => x.StoreId == y).ToList();
            foreach (var p in storeProducts) {
                var product = context.Products.Where(x => x.ProductId == p.ProductId).FirstOrDefault();
                Console.WriteLine($" {product.ProductName} : {product.ProductDescription} price: {product.ProductPrice}$");
            }
        }

    }
}
