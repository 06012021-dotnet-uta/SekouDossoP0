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
    public class Register : IRegisterUser
    {
        // first define the context 
        private readonly P1Db _context;
        private List<User> ps ;

        // create a constructor
        /// <summary>
        /// create constructor to make the dependency injection
        /// </summary>
        /// <param name="context"></param>
        public Register(P1Db context) { this._context = context; }
        // currentUser
        User currentUser = null;
        // register new customer 
        /// <summary>
        ///  register new user before login
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> RegisterUserAsync(User user)
        {
            // create a try/catch  to save user
            await _context.Users.AddAsync(user);
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

            // create account
            var userAccount = new Account(user.UserName, user.UserPassWord);
            await _context.Accounts.AddAsync(userAccount);
            try
            {
                await _context.SaveChangesAsync();
            }
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
            // currentUser
            currentUser = user;
            // instantiate a shopping cart iimediately for the new customer 
            var newCart = new Cart(user.UserId);
            await _context.Carts.AddAsync(newCart);
            try
            {
                await _context.SaveChangesAsync();
            }
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
            // _context.SaveChanges();
            return true;
        }
        
        // log in
        /// <summary>
        /// not using this login , I will clean it later
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> LoginAsync(User user)
        {
            // create a try/catch  to save user
            try { var currentUser = _context.Users.Where(x => x.Email == user.Email && x.UserPassWord == user.UserPassWord).FirstOrDefault(); }
            catch (Exception ex)
            {
                Console.WriteLine($"User not found => {ex.InnerException}");
                return false;
            }
            currentUser = user;
            return true;
        }

        // userList 
        /// <summary>
        ///  get the list of all order of  all Users
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> UserListAsync()
        {
            // List<User> ps = null;
            // List<User> ps = new List<User>();
            try
            {
                ps = await _context.Users.ToListAsync();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}"); //or {ex.Message}
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex}");
            }
            return ps;
        }
    }
}
