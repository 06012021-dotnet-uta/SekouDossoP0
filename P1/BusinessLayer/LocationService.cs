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
    public class LocationService : ILocation
    {
        // first define the context 
        private readonly P1Db _context;
        private List<Location> ps;

        // create a constructor
        /// <summary>
        ///  constructor for dependency injection
        /// </summary>
        /// <param name="context"></param>
        public LocationService(P1Db context) { this._context = context; }

        /// <summary>
        /// Admin privilege create new location
        /// </summary>
        /// <param name="location"></param>
        /// <returns> bool </returns>
        public async Task<bool> RegisterLocationAsync(Location location)
        {
            // create a try/catch  to save user
            await _context.Locations.AddAsync(location);
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
        /// get location list 
        /// </summary>
        /// <returns> ps </returns>
        public async Task<List<Location>> LocationListAsync()
        {
            // List<Location> ps = null;
            try
            {
                ps = _context.Locations.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return ps;
        }
    }
}

