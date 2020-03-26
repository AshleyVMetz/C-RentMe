using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentMe.DAL;

namespace RentMe.Controller
{
   
    class LoginController
    {
        private LoginDAL loginDAL;

        public LoginController()
        {
            this.loginDAL = new LoginDAL();
        }

        public bool? EmployeeLogin (string username, string password)
        {
            return loginDAL.EmployeeLogin(username, password);
        }

        
    }
}
