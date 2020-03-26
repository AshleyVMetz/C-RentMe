using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a login
    /// </summary>
    public class Login
    {
        public string Username { get; }
        public string Password { get; }
        public bool IsAdmin { get; }
    }
}
