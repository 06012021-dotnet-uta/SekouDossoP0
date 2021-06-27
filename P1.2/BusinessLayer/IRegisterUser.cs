using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IRegisterUser
    {
        Task<bool> RegisterUserAsync(User user);
        Task<List<Account>> LoginAsync();
        Task<List<User>> UserListAsync();
    }
}
