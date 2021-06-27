using Microsoft.EntityFrameworkCore;
using ModelsLayer;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CartProductService : ICartProduct
    {
        // first define the context 
        private readonly P1Db _context;

        // create a constructor
        public CartProductService(P1Db context) { this._context = context; }
        // currentUser
        // User currentUser = null;
        // register new customer 

        // AddProductAsync
        public async Task<bool> AddProductAsync(Product p)
        {
            var cartProduct = new CartProduct(p.ProductId, 1);
                // create a try/catch  to save user
                await _context.CartProducts.AddAsync(cartProduct);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    Console.WriteLine($"There was a problem updating the Db => {ex.InnerException}");
                    return false;
                }
                catch (DbUpdateException ex)
                {       //change this to logging
                    Console.WriteLine($"There was a problem updating the Db => {ex.InnerException}");
                    return false;
                }
                return true;
        }

        //CartProductsAsync();
        public async Task<List<CartProduct>> CartProductsAsync()
        {
            List<CartProduct> ps = null;
            try
            {
                ps = _context.CartProducts.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return ps;
        }


    }
}
