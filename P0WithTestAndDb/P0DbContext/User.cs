using System;
using System.Collections.Generic;

#nullable disable

namespace P0DbContext
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string UserPassWord { get; set; }
    }
}
