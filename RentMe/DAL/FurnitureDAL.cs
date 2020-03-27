using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.DAL
{
    /// <summary>
    /// Data Access Layer for all Furniture related functionalities
    /// </summary>
    class FurnitureDAL
    {
        /// <summary>
        /// Returns all Styles
        /// </summary>
        /// <returns>List of Technicians</returns>
        public List<Style> GetStyles()
        {
            List<Style> styleList = new List<Style>();

            string selectStatement =
                "SELECT * FROM dbo.Style ORDER BY Description";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Style style = new Style();
                            style.StyleID = (int)reader["StyleID"];
                            style.Description = reader["Description"].ToString();
                            styleList.Add(style);
                        }
                    }
                }
            }

            return styleList;
        }

        /// <summary>
        /// Returns all Categories
        /// </summary>
        /// <returns>List of Categories</returns>
        public List<Category> GetCategories()
        {
            List<Category> categoryList = new List<Category>();

            string selectStatement =
                "SELECT * FROM dbo.Category ORDER BY Description";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Category category = new Category();
                            category.CategoryID = (int)reader["CategoryID"];
                            category.Description = reader["Description"].ToString();
                            categoryList.Add(category);
                        }
                    }
                }
            }

            return categoryList;
        }
    }
}
