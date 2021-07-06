using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IProduct
    {
        Task<bool> RegisterProductAsync(Product product);
        Task<List<Product>> ProductListAsync(); // product list
        Task<List<Location>> LocationListAsync();  // location list 
        Task<List<Store>> StoreListAsync(); // store list 
        Task<List<StoreProduct>> StoreProductListAsync(); // product list
        Task<bool> GetLocationAsync(string searchString);  // get location
    }
}
