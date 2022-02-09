using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wmad.Party.Store
{
    public class Balloon //PascaleCase
    {
        #region Private Fields

        /*
         * camelCase for fields
         */
        private string colour;
        private int height;
        private int diameter;

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
                diameter = value;
            }
        }

        #endregion
    }
}
