using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IStore
    {
        Task<bool> RegisterStoreAsync(Store store);
        Task<List<Store>> StoreListAsync();
    }
}
