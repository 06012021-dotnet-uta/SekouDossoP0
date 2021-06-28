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
        static User _user;

        // create a constructor
        public AccountService(P1Db context) { 
            this._context = context;
            _user = new User();
        }

        // login  
        // log in [P1Db].[dbo].[Accounts]
        public async Task<List<Account>> LoginAsync(Account currentUser)
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

            _user = _context.Users.ToList().Where(x => x.UserName == currentUser.UserName).FirstOrDefault();
            //Console.WriteLine($"user => {User}");

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

        // current user
        public static User CurrentUser()
        {
            return _user;
        }



    }
}