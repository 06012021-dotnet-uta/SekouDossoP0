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
        private List<Product> ps;
        private List<StoreProduct> stp;
        private List<Store> stl;
        private List<Location> ll;
        static Location _location;
        // constructor 
        /// <summary>
        ///  create constructor to make the dependency injection
        /// </summary>
        /// <param name="context"></param>
        public ProductService (P1Db context)
        {
            this._context = context;
        }

        /// <summary>
        ///  Admin privilege
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
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

        /// <summary>
        /// get the list of all order of  all products
        /// </summary>
        /// <returns></returns>
        public async Task<List<Product>> ProductListAsync()
        {
            // List<Product> ps = null;
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

        // store product list 
        /// <summary>
        ///  get the list of all order of  all stock in StoreProduct
        /// </summary>
        /// <returns></returns>
        public async Task<List<StoreProduct>> StoreProductListAsync()
        {
            // List<Product> stp = null;
            try
            {
                stp = _context.StoreProducts.ToList();

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return stp;
        }

        // Store list 
        /// <summary>
        ///  get the list of all order of  all Store
        /// </summary>
        /// <returns></returns>
        public async Task<List<Store>> StoreListAsync()
        {
            //List<Store> stl = null;
            try
            {
                stl = _context.Stores.ToList();

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return stl;
        }

        // location list 
        /// <summary>
        ///  get the list of all order of  all locations
        /// </summary>
        /// <returns></returns>
        public async Task<List<Location>> LocationListAsync()
        {
            // List<Location> ll = null;
            try
            {
                ll = _context.Locations.ToList();

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return ll;
        }

        // get Location await _product.GetLocationAsync(searchString);
        /// <summary>
        ///  get location info when user select location for shopping
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public async Task<bool> GetLocationAsync(string searchString)
        {

            _location = _context.Locations.ToList().Where(x => x.LocationName == searchString).FirstOrDefault();
            Console.WriteLine(_location);
            return true;
        }

        // current location
        /// <summary>
        ///  save location info to make it available later
        /// </summary>
        /// <returns></returns>
        public static Location CurrentLocation()
        {
            return _location;
        }
    }
}
