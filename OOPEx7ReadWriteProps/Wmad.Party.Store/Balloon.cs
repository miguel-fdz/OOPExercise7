using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wmad.Party.Store
{
    public class Balloon //PascaleCase
    {
        #region Private Fields

        //camelCase for fields
        private string colour;
        private int height;
        private int diameter;

        #endregion

        #region Auto Properties

        public bool HasString { get; set; }

        #endregion

          #region Public Properties

        /// <summary>
        /// This is the balloon colour
        /// </summary>
        public string Colour
        {
            get
            {
                return colour;
            }
            set
            {
                colour = value.Trim();
            }
        }

        /// <summary>
        /// This is the balloon height
        /// </summary>
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                //Validate the height. It must be between 1 and 10 inclusive
                if (value < 1 || value > 10)

                    throw new ConstraintException("Height must be between 1 and 10");
                height = value;
            }
        }

        /// <summary>
        /// This is the balloon diameter
        /// </summary>
        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                //make sure colour has already been set
                if (String.IsNullOrEmpty(Colour))
                    throw new DataException("Colour must be set before diameter");

                //diameter validations
                if (Colour.ToLower() == "red" && value < 12)
                    throw new ConstraintException("Diameter for a red balloon must be 12 or higher. ");
                else if (Colour.ToLower() == "white" && value < 10)
                    throw new ConstraintException("Diameter for a white balloon must be 12 or higher. ");
                else if (value <= 0)
                    throw new ConstraintException("Diameter must be greater than 0. ");
                else 
                    diameter = value;
            }
        }

        #endregion
    }
}
