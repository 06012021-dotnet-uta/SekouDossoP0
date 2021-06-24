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
    public class ProductService : IProduct
    {
        // DbContext 
        private readonly P1Db _context;
        // constructor 
        public ProductService (P1Db context)
        {
            this._context = context;
        }
        public async Task<bool> RegisterProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            try { await _context.SaveChangesAsync(); }
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
        public async Task<List<Product>> ProductListAsync()
        {
            List<Product> ps = null;
            try
            {
                ps = _context.Products.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return ps;
        }
    }
}
