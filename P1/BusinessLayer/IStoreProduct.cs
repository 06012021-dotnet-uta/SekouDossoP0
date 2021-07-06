using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IStoreProduct
    {
        Task<bool> RegisterStoreProductAsync(StoreProduct st);
        Task<List<StoreProduct>> StoreProductListAsync(); // store product list
        Task<List<Product>> ProductListAsync(); // product list
        Task<List<Store>> StoreListAsync(); // store list
        Task<List<Location>> LocationListAsync(); // location list
    }
}
