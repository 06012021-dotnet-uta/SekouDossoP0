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
        // Task<List<Account>> LoginAsync(Account currentUser);

        Task<bool> LoginAsync(Account a);
        Task<List<Account>> AccountListAsync(); // account list
    }
}