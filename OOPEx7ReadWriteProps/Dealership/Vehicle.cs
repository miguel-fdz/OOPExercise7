using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership
{
    public class Vehicle
    {
        #region Private Fields

        private string make;
        private string model;
        private string vin;
        private int year;
        private int doors;
        private string fuel;

        #endregion

        #region Public Properties

        /// <summary>
        /// This is the Vehicle's Make
        /// </summary>
        public string Make {
            get
            {
                return make;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new DataException("Make is required.");
                else
                    make = value.Trim();
            } 
        }

        /// <summary>
        /// This is the Vehicle's Model
        /// </summary>
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new DataException("Model is required.");
                else
                    model = value.Trim();
            }
        }

        /// <summary>
        /// This is the Vehicle's VIN
        /// </summary>
        public string Vin
        {
            get
            {
                return vin;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new DataException("VIN required.");
                else if (value.Length != 17)
                    throw new ConstraintException("VIN is not in a valid format.");
                else
                    vin = value.Trim();
            }
        }

        /// <summary>
        /// This is the Vehicle's Year
        /// </summary>
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                int maxYear = DateTime.Now.Year + 1;
                if (value > maxYear || value < 1920)
                    throw new ConstraintException("Year cannot be less than 1920 or greater than 2021.");
                else
                    year = value;
            }
        }

        /// <summary>
        /// This is the Vehicle's Doors
        /// </summary>
        public int Doors
        {
            get
            {
                return doors;
            }
            set
            {
                if (value < 2 || value > 4 )
                    throw new ConstraintException("The number of doors is 2, 3 or 4 only.");
                else
                    doors = value;
            }
        }

        /// <summary>
        /// This is the Vehicle's Fuel Type
        /// </summary>
        public string Fuel
        {
            get
            {
                return fuel;
            }
            set
            {
                if (value != "Gas" && value != "Diesel" && value != "Hybrid" && value != "Electric")
                    throw new DataException("Invalid fuel type.");
                else
                    fuel = value.Trim();
            }
        }

        #endregion
    }
}
