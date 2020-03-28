using RentMe.DAL;
using RentMe.Model;

namespace RentMe.Controller
{
    /// <summary>
    /// This class is the controller for the login.
    /// </summary>
    class LoginController
    {
        private LoginDAL loginDAL;

        public LoginController()
        {
            this.loginDAL = new LoginDAL();
        }

        /// <summary>
        /// This class references the employee login.
        /// </summary>
        /// <param name="username">String of entered username</param>
        /// <param name="password">String of entered password</param>
        /// <returns></returns>
        public LoginResult EmployeeLogin(string username, string password)
        {
            return loginDAL.EmployeeLogin(username, password);
        }


    }
}
