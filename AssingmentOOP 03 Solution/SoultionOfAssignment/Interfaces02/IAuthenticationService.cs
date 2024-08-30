using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOfAssignment.Interfaces02
{
    internal interface IAuthenticationService
    {
        bool AuthenticateUser(string UserName , string Password);
        bool AuthorizeUser(string UserName, string Role);

    }
}