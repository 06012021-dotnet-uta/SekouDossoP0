using System;
using System.Collections.Generic;

#nullable disable

namespace P0DbContext
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserPassWord { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
