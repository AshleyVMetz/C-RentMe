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

    }
}
