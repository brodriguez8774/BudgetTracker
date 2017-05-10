using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetTracker.Models
{
    /// <summary>
    /// Standard Address Model.
    /// </summary>
    public class Address
    {
        #region Variables

        protected string street;                  // Street name.
        protected string city;                    // City name.
        protected string region;                  // Region name.
        protected int postalCode;                 // Postal code.

        #endregion Variables



        #region Constructors

        /// <summary>
        /// Base Constructor.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="region"></param>
        /// <param name="postalCode"></param>
        public Address(string street, string city, string region, int postalCode)
        {
            Street = street;
            City = city;
            Region = region;
            PostalCode = postalCode;
        }

        #endregion Constructors



        #region Properties

        /// <summary>
        /// Street name.
        /// </summary>
        public string Street
        {
            get { return street; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("street", "Invalid street. Value is null.");
                }
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Invalid street. Value is empty.", "street");
                }
                street = value;
            }
        }

        /// <summary>
        /// City name.
        /// </summary>
        public string City
        {
            get { return city; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("city", "Invalid city. Value is null.");
                }
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Invalid city. Value is empty.", "city");
                }
                city = value;
            }
        }

        /// <summary>
        /// Region name.
        /// </summary>
        public string Region
        {
            get { return region; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("region", "Invalid region. Value is null.");
                }
                region = value;
            }
        }

        /// <summary>
        /// Postal code.
        /// </summary>
        public int PostalCode
        {
            get { return postalCode; }
            set
            {
                if (value <= 99)
                {
                    throw new ArgumentOutOfRangeException("postalCode", "Invalid postal code. Value should be 3 or more digits.");
                }
                if (value >= 1000000000)
                {
                    throw new ArgumentOutOfRangeException("postalCode", "Invalid postal code. Value should be 10 or less digits.");
                }
                postalCode = value;
            }
        }

        #endregion Properties

    }
}
