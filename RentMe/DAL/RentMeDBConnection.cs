using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
