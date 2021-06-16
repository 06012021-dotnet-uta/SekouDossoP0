using System;
// using Linq;
using P0DbContext;
namespace P0
{
    public class MapperClassAppToDb
    {
        public static User AppUserToDbUser(User user){
             User u = new User(){
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                UserPassWord = user.UserPassWord,
            };
            return u;
        }
    }
}