using ModelsLayer;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AccountService : IAccount
    {
        // first define the context 
        private readonly P1Db _context;
        private List<Account> ps;

        // create a constructor
        public AccountService(P1Db context) { this._context = context; }

        // login  
        // log in [P1Db].[dbo].[Accounts]
        public async Task<List<Account>> LoginAsync()
        {
            // List<Account> ps = null;
            // List<Account> ps = new List<Account>();
            try
            {
                ps = _context.Accounts.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex}");
            }
            return ps;
        }

        // account List 
        public async Task<List<Account>> AccountListAsync()
        {

            try
            {
                ps = _context.Accounts.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex}");
            }
            return ps;
        }

    }
}