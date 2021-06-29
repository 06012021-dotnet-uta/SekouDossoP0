using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelsLayer;
using RepositoryLayer;

namespace BusinessLayer
{
    public class StoreService : IStore
    {
        // define a private prop for context
        private readonly P1Db  _context;
        private List<Store> ps;
        // constructor 
        /// <summary>
        /// create constructor to make the dependency injection
        /// </summary>
        /// <param name="context"></param>
        public StoreService (P1Db context)
        {
            this._context = context;
        }
        //implement IStore methods
        /// <summary>
        ///  Admin privilege
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public async Task<bool> RegisterStoreAsync(Store store)
        {
            // create a try/catch  to save user
            await _context.Stores.AddAsync(store);
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

        // userList 
        /// <summary>
        /// get the list of all order of  all users
        /// </summary>
        /// <returns></returns>
        public async Task<List<Store>> StoreListAsync()
        {
           // List<Store> ps = null;
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

    }
}
