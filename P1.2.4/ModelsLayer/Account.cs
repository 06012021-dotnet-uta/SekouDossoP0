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
        //[ForeignKey("UserId")]
       // public int UserId { get; set; }
        public User User { get; set; }
        //[ForeignKey("UserPassWord")]
        public string UserPassWord { get; set; }
        public Account()
        {
            UserName = "userName";
            UserPassWord = "userPassWord";
            //UserId = 1;
        }
        public Account(string userName, string userPassWord)
        {
            this.UserName = userName;
            this.UserPassWord = userPassWord;
            // this.UserId = userId;
        }
    }

}