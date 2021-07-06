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
        /// <summary>
        /// create constructor to make the dependency injection
        /// </summary>
        /// <param name="context"></param>
        public AccountService(P1Db context) { 
            this._context = context;
            _user = new User();
        }

        // login  
        /// <summary>
        ///  Afeter Login successefully I save the user info here to make it available later.
        /// </summary>
        /// <param name="currentUser"></param>
        /// <returns></returns>
        // public async Task<List<Account>> LoginAsync(Account currentUser)
        // {
        //     // List<Account> ps = null;
        //     // List<Account> ps = new List<Account>();
        //     try
        //     {
        //         ps = _context.Accounts.ToList();
        //     }
        //     catch (ArgumentNullException ex)
        //     {
        //         Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
        //     }
        //     catch (Exception ex)
        //     {
        //         Console.WriteLine($"There was a problem gettign the players list => {ex}");
        //     }

        //     _user = _context.Users.ToList().Where(x => x.UserName == currentUser.UserName).FirstOrDefault();
        //     //Console.WriteLine($"user => {User}");

        //     return ps;
        // }
        public async Task<bool> LoginAsync(Account a)
        {
            // List<Account> ps = null;
            // List<Account> ps = new List<Account>();
            bool al = true;
            try
            {
                al =  _context.Accounts.Where(x => x.UserName==a.UserName && x.UserPassWord==a.UserPassWord).ToList().Count>0;

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex}");
                return false;
            }

            _user = _context.Users.ToList().Where(x => x.UserName == a.UserName).FirstOrDefault();
            //Console.WriteLine($"user => {User}");

            return al;
        }

        // account List 
        /// <summary>
        /// get the list of all order of  all accounts to search for current user.
        /// </summary>
        /// <returns></returns>
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
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return ps;
        }

        // current user
        /// <summary>
        ///  I save current user info here to make it available later.
        /// </summary>
        /// <returns></returns>
        public static User CurrentUser()
        {
            return _user;
        }
        
    }
}