using RentMe.DAL;
using RentMe.Model;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// This class is the controller for the Furniture.
    /// </summary>
    class FurnitureController
    {
        private FurnitureDAL furnitureDAL;

        public FurnitureController()
        {
            this.furnitureDAL = new FurnitureDAL();
        }

        /// <summary>
        /// Returns all Styles
        /// </summary>
        /// <returns>List of Technicians</returns>
        public List<Style> GetStyles()
        {
            return this.furnitureDAL.GetStyles();
        }

        /// <summary>
        /// Returns all Categories
        /// </summary>
        /// <returns>List of Categories</returns>
        public List<Category> GetCategories()
        {
            return this.furnitureDAL.GetCategories();
        }

        /// <summary>
        /// Get Furnitures using Serial Number
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns>Furniture List</returns>
        public List<Furniture> GetFurnituresBySerialNumber(string serialNumber)
        {
            return this.furnitureDAL.GetFurnituresBySerialNumber(serialNumber);
        }

        /// <summary>
        /// Get Furnitures using Style
        /// </summary>
        /// <param name="styleId"></param>
        /// <returns>Furniture List</returns>
        public List<Furniture> GetFurnituresByStyle(int styleId)
        {
            return this.furnitureDAL.GetFurnituresByStyle(styleId);
        }

        /// <summary>
        /// Get Furnitures using Category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>Furniture List</returns>
        public List<Furniture> GetFurnituresByCategory(int categoryId)
        {
            return this.furnitureDAL.GetFurnituresByCategory(categoryId);
        }

        /// <summary>
        /// Find number of available furnitures
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns>Number of furnitures available</returns>
        public int GetCurrentFurnitureCount(string serialNumber)
        {
            return this.furnitureDAL.GetCurrentFurnitureCount(serialNumber);
        }

    }
}
