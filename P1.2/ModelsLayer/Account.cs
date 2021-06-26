using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Account
    {
        [key]
        public int AccountId { get; set; }
        [ForeignKey("UserName")]
        public string UserName { get; set; }
        [ForeignKey("UserPassword")]
        public string UserPassword { get; set; }
        public User User { get; set; }
    }
}
