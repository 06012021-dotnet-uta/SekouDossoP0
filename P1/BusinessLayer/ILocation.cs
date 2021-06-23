using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface ILocation
    {
        Task<bool> RegisterLocationAsync(Location location);
        Task<List<Location>> LocationListAsync();
    }
}
