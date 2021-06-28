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
    public class OrderProductService : IOrderProduct
    {
        // DbContext 
        private readonly P1Db _context;
        private List<OrderProduct> ps;
        // constructor 
        public OrderProductService(P1Db context)
        {
            this._context = context;
        }
        public async Task<bool> RegisterOrderProductAsync(OrderProduct op)
        {
            await _context.OrderProducts.AddAsync(op);
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
        public async Task<List<OrderProduct>> OrderProductListAsync()
        {
            // List<OrderProduct> ps = null;
            try
            {
                ps = _context.OrderProducts.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return ps;
        }
    }
}
