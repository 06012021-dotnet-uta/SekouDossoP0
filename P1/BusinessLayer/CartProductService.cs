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
        private List<CartProduct> ps;
        private List<Product> pl;
        static List<Product> Products { get; set; }
        static User User;

        // create a constructor
        /// <summary>
        /// create constructor to make the dependency injection
        /// </summary>
        /// <param name="context"></param>
        public CartProductService(P1Db context)
        {
            this._context = context;
            Products = new List<Product>();
        }


        // AddProductAsync
        /// <summary>
        /// Admin privilege
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<bool> AddProductAsync(Product p)
        {
            Products.Add(p);
            var n = new CartProduct(1, p.ProductId);
            await _context.AddAsync(n);
            await _context.SaveChangesAsync();

            return true;
        }

        // list OfCartProduct 
        /// <summary>
        ///  get the list of all order of  all CartProduct.
        /// </summary>
        /// <returns></returns>
        public async Task<List<CartProduct>> ListOfCartProductsAsync()
        {
            //  ps = _context.Users.ToList();
            ps = _context.CartProducts.ToList();

            return ps;
        }

        //CartProductsAsync();
        /// <summary>
        ///  get the list of all order of  all CartProduct
        /// </summary>
        /// <returns></returns>
        public async Task<List<CartProduct>> CartProductsAsync()
        {
            // List<CartProduct> ps = null;
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

        // ListOfProductsAsync
        /// <summary>
        /// get the list of all order of  all Products
        /// </summary>
        /// <returns></returns>
        public async Task<List<Product>> ListOfProductsAsync()
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

        // checkout 
        /// <summary>
        ///  this is a transaction
        /// all pass together or faill together 
        /// first create order 
        /// get the id of the last order 
        /// check for stock disponibility
        /// place order is stock is enougth
        /// </summary>
        /// <returns></returns>
        public async Task<bool> CheckoutAsync( )
        {
            // create order
            // user 
                var user = AccountService.CurrentUser();
                Console.WriteLine(user);
            //store 
            var location = ProductService.CurrentLocation();
            Console.WriteLine(location);
            // create orderProduct 
            var newOrder = new Order(DateTime.Today, user.UserId, location.LocationId);
            await _context.Orders.AddAsync(newOrder);
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
            // create OrderProduct 
            var lastOrder = _context.Orders.ToList().Last();
            var cartProdList = _context.CartProducts.ToList();
            foreach (var x in cartProdList)
            {
                // create new Orderproduct and set the quantity to 1
                var newOrderProduct = new OrderProduct(lastOrder.OrderId, x.ProductId, 1);
                // check stock 
                var stock = _context.StoreProducts.Where(y => y.ProductId == x.ProductId && 
                                                         y.Store.LocationId == location.LocationId).FirstOrDefault();
                if (stock.Quantity > 0)
                {
                    await _context.OrderProducts.AddAsync(newOrderProduct);
                    stock.Quantity = stock.Quantity - 1;
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
                }
            }

            // delete all record in cartproduct table 
            /// <summary>
            ///  Empty cart afert checkout
            /// </summary>
            /// <returns></returns>
            var emptyCart =  _context.CartProducts.ToList();
            foreach( var x in emptyCart) { _context.CartProducts.Remove(x); }
            _context.SaveChanges();

            return true;
        }

    }
}
