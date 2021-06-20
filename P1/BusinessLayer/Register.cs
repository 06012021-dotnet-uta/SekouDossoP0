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
    public class Register
    {
        // first define the context 
        private readonly P1Db _context;
        public Register(P1Db context)
        {
            this._context = context;
        }
        // create a constructor
        /// <summary>
		/// Saves a new User ot the Db. If un successful, returns false, otherwise TRUE.
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
        public async Task<bool> RegisterUser(User user)
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
    }
}
