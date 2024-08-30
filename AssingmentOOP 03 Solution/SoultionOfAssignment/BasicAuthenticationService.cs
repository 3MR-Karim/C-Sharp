using SolutionOfAssignment.Interfaces02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOfAssignment
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        string Username = "Sayed";
        string Password = "123";
        string role = "User";

        public bool AuthenticateUser(string UserName, string PassWord)
        {
            if (Username == UserName && Password == PassWord) { return true; }
            else { return false; }
        }

        public bool AuthorizeUser(string UserName, string Role)
        {
            if (Username == UserName && role == Role) { return true; }
            else { return false; }
        }
    }
}
