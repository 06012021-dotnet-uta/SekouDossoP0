using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Linq;
using P0DbContext;

namespace P0
{
    class DisplayProducts
    {
        /// <summary>
        /// Display store's products to the user before he starts shopping
        /// </summary>
        /// <param name="store_id"></param>
        /// <returns></returns>
      

        public static void Display(int store_id)
        {
            // var currentUser = db.Users
            //       .Where(x => x.FisrtName == "Sekou");
            //    Console.WriteLine($"the current user is : {currentUser.FirstOrDefault().FisrtName}");
            P0DBContext context = new P0DBContext();
            var storeProducts = context.StoreProducts.Where(x => x.StoreId == store_id).ToList();
            foreach (var p in storeProducts) {
                var product = context.Products.Where(x => x.ProductId == p.ProductId).FirstOrDefault();
                Console.WriteLine($" Product name: {product.ProductName} -- product descrition: {product.ProductDescription} -- price: {product.ProductPrice}$");
            }
        }

    }
}
