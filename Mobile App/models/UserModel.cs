using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_App.models
{
    internal class UserModel
    {
        public UserModel(string? username, string? password)
        {
            this.username = username;
            this.password = password;
        }

        public string? username { set; get; }
        public string? password { set; get; }
    }
}
