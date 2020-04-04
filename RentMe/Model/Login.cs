namespace RentMe.Model
{
    /// <summary>
    /// This class models a login
    /// </summary>
    public class LoginResult
    {
        public int EmployeeID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
