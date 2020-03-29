using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// Creates Connection to SQL Server
    /// </summary>
    class RentMeDBConnection
    {
        /// <summary>
        /// Creates and returns new connection to database
        /// </summary>
        /// <returns>SQL Connection object</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=CS6232-g2;" +
                "Integrated Security=True";


            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
