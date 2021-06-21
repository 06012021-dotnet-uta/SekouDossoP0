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
        // create a constructor
        public Register(P1Db context)
        {
            this._context = context;
        }
       
        public async Task<bool> RegisterPlayerAsync(User user)
        {
            // create a try/catch  to save user
            await _context.Users.AddAsync(user);
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

            return true;

        }

        // userList 
        public async Task<List<User>> UserListAsync()
        {
            List<User> ps = null;
            try
            {
                ps = _context.Users.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return ps;
        }
    }
}
