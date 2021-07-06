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
    public class OrderService : IOrder 
    {
        // first define the context 
        private readonly P1Db _context;
        private List<Order> ps;
        private List<Location> ls;
        private List<User> ul;
        private List<OrderProduct> opl;
        private List<Product> pl;

        // create a constructor
        /// <summary>
        /// create constructor to make the dependency injection
        /// </summary>
        /// <param name="context"></param>
        public OrderService(P1Db context) { this._context = context; }

        /// <summary>
        /// Create an order 
        ///  require LocationId and UserId
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public async Task<bool> CreateOrderAsync(Order order)
        {
             //create a try/catch  to save user
            await _context.Orders.AddAsync(order);
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

         //order List 
         /// <summary>
         /// get the list of all orders
         /// </summary>
         /// <returns></returns>
        public async Task<List<Order>> OrderListAsync()
        {
           // List<Order> ps = null;
            try
            {
                ps = _context.Orders.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return ps;
        }
        // location orders List 
        /// <summary>
        /// get the list of all order of  all locations
        /// </summary>
        /// <returns></returns>
        public async Task<List<Location>> LocationOrderListAsync()
        {
            // List<Location> ls = null;

            try
            {
                ls = _context.Locations.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return ls;    
        }
        // users orders List 
        /// <summary>
        /// get the list of all orders of all users
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> UserOrderListAsync()
        {
            List<User> ul = null;

            try
            {
                ul = _context.Users.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return ul;    
        }

        // orderProduct list OrderProductListAsync()
        /// <summary>
        /// get the list of all orderProduct
        /// </summary>
        /// <returns></returns>
        public async Task<List<OrderProduct>> OrderProductListAsync()
        {
            // List<OrderProduct> ul = null;

            try
            {
                opl= _context.OrderProducts.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return opl;
        }

        // Product list ProductListAsync()
        /// <summary>
        /// get the list of all products
        /// </summary>
        /// <returns></returns>
        public async Task<List<Product>> ProductListAsync()
        {
            // List<OrderProduct> ul = null;

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

    }
}
