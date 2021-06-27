using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IAccount
    {
         Task<List<Account>> LoginAsync();  // login  
        Task<List<Account>> AccountListAsync(); // account list
    }
}