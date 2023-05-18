using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    internal class Account
    {
        private string UserName;
        private string Password;

        public Account(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        public string username { get => UserName; set => UserName=value; }
        public string password { get => Password; set => UserName = Password; }
        
    }
}
