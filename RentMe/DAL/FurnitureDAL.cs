using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

        /// <summary>
        /// Get Furnitures using Serial Number
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns>Furniture List</returns>
        public List<Furniture> GetFurnituresBySerialNumber(string serialNumber)
        {
            List<Furniture> furnitureList = new List<Furniture>();

            string selectStatement =
                "select Serial#, f.Description, Quantity, FineRate, DailyRentalRate, s.Description as Style, c.Description as Category  from dbo.FurnitureItem f " +
                "JOIN dbo.Style s on f.StyleID = s.StyleID " +
                "JOIN dbo.Category c on f.CategoryID = c.CategoryID " +
                "WHERE lower(f.Serial#) = lower(@SerialNumber) ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@SerialNumber", serialNumber);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            furniture.SerialNumber = reader["Serial#"].ToString();
                            furniture.Description = reader["Description"].ToString();
                            furniture.Quantity = (int)reader["Quantity"]; 
                            furniture.FineRate = Convert.ToDouble(reader["FineRate"]);
                            furniture.DailyRentalRate = Convert.ToDouble(reader["DailyRentalRate"]);
                            furniture.Style = reader["Style"].ToString();
                            furniture.Category = reader["Category"].ToString();

                            furnitureList.Add(furniture);
                        }
                    }
                }
            }

            return furnitureList;
        }

        /// <summary>
        /// Get Furnitures using Style
        /// </summary>
        /// <param name="styleId"></param>
        /// <returns>Furniture List</returns>
        public List<Furniture> GetFurnituresByStyle(int styleId)
        {
            List<Furniture> furnitureList = new List<Furniture>();

            string selectStatement =
                "select Serial#, f.Description, Quantity, FineRate, DailyRentalRate, s.Description as Style, c.Description as Category  from dbo.FurnitureItem f " +
                "JOIN dbo.Style s on f.StyleID = s.StyleID " +
                "JOIN dbo.Category c on f.CategoryID = c.CategoryID " +
                "WHERE s.StyleID = @StyleId ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@StyleId", styleId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            furniture.SerialNumber = reader["Serial#"].ToString();
                            furniture.Description = reader["Description"].ToString();
                            furniture.Quantity = (int)reader["Quantity"];
                            furniture.FineRate = Convert.ToDouble(reader["FineRate"]);
                            furniture.DailyRentalRate = Convert.ToDouble(reader["DailyRentalRate"]);
                            furniture.Style = reader["Style"].ToString();
                            furniture.Category = reader["Category"].ToString();

                            furnitureList.Add(furniture);
                        }
                    }
                }
            }

            return furnitureList;
        }

        /// <summary>
        /// Get Furnitures using Category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>Furniture List</returns>
        public List<Furniture> GetFurnituresByCategory(int categoryId)
        {
            List<Furniture> furnitureList = new List<Furniture>();

            string selectStatement =
                "select Serial#, f.Description, Quantity, FineRate, DailyRentalRate, s.Description as Style, c.Description as Category  from dbo.FurnitureItem f " +
                "JOIN dbo.Style s on f.StyleID = s.StyleID " +
                "JOIN dbo.Category c on f.CategoryID = c.CategoryID " +
                "WHERE c.CategoryID = @CategoryId ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@CategoryId", categoryId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            furniture.SerialNumber = reader["Serial#"].ToString();
                            furniture.Description = reader["Description"].ToString();
                            furniture.Quantity = (int)reader["Quantity"];
                            furniture.FineRate = Convert.ToDouble(reader["FineRate"]);
                            furniture.DailyRentalRate = Convert.ToDouble(reader["DailyRentalRate"]);
                            furniture.Style = reader["Style"].ToString();
                            furniture.Category = reader["Category"].ToString();

                            furnitureList.Add(furniture);
                        }
                    }
                }
            }

            return furnitureList;
        }
    }
}
