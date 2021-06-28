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
        public Register(P1Db context) { this._context = context; }
        // currentUser
        User currentUser = null;
        // register new customer 
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
        public async Task<List<User>> UserListAsync()
        {
            // List<User> ps = null;
            // List<User> ps = new List<User>();
            try
            {
                ps = _context.Users.ToList();
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
