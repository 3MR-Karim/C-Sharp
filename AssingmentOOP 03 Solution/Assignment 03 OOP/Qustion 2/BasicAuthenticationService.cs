using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOP.Qustion_2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private readonly Dictionary<string, (string Password, string Role)> _userStore = new Dictionary<string, (string Password, string Role)>
    {
        { "user1", ("password1", "admin") },
        { "user2", ("password2", "user") }
    };
        public bool AuthenticateUser(string username, string password)
        {
            if (_userStore.ContainsKey(username))
            {
                return _userStore[username].Password == password;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (_userStore.ContainsKey(username))
            {
                return _userStore[username].Role == role;
            }
            return false;
        }
    }
}
