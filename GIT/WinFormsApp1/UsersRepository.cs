using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class UsersRepository
    {
        public List<User> Users { get; private set; }
        public UsersRepository()
        {
            Users = new List<User>();
            Users.Add(new User { Login = "admin", Password = "admin" });
            Users.Add(new User { Login = "user", Password = "user" });
        }
    }
}
