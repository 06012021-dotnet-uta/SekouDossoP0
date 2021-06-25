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
        Task<bool> LoginAsync(User user);
        Task<List<User>> UserListAsync();
    }
}
