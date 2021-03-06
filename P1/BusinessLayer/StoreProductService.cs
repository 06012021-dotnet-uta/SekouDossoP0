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
    public class StoreProductService : IStoreProduct
    {
        // first define the context 
        private readonly P1Db _context;
        private List<StoreProduct> ps;
        private List<Product> pl;

        // create a constructor
        /// <summary>
        /// create constructor to make the dependency injection
        /// </summary>
        /// <param name="context"></param>
        public StoreProductService(P1Db context) { this._context = context; }

        /// <summary>
        ///  Admin privilege
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>

        public async Task<bool> RegisterStoreProductAsync(StoreProduct st)
        {
            // create a try/catch  to save user
            await _context.StoreProducts.AddAsync(st);
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

        // store product List 
        /// <summary>
        /// get the list of all order of  all  StoreProduct 
        /// </summary>
        /// <returns></returns>

        public async Task<List<StoreProduct>> StoreProductListAsync()
        {
            // List<StoreProduct> ps = null;
            try
            {
                ps = _context.StoreProducts.ToList();
               
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return ps;
        }

        // product list 
        /// <summary>
        /// get the list of all order of  all Product
        /// </summary>
        /// <returns></returns>
        public async Task<List<Product>> ProductListAsync()
        {
           // List<Product> pl = null;
            try
            {
                pl = _context.Products.ToList();

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return pl;
        }

        // Store list 
        /// <summary>
        ///  get the list of all order of  all Store
        /// </summary>
        /// <returns></returns>
        public async Task<List<Store>> StoreListAsync()
        {
            List<Store> ps = null;
            try
            {
                ps = _context.Stores.ToList();

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return ps;
        }

        // location list 
        /// <summary>
        /// get the list of all order of  all locations
        /// </summary>
        /// <returns></returns>
        public async Task<List<Location>> LocationListAsync()
        {
            List<Location> ps = null;
            try
            {
                ps = _context.Locations.ToList();

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return ps;
        }


    }
}
