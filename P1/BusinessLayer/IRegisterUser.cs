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
        Task<bool> RegisterPlayerAsync(User user);
        Task<List<User>> UserListAsync();
    }
}
