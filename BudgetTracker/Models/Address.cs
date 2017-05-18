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
    public class Address : IComparable
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
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Invalid region. Value is empty.", "region");
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



        #region Methods

        /// <summary>
        /// Compares Address objects using:
        /// Postal Code, Region, City, and Street.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Compare value of address.</returns>
        public int CompareTo(object obj)
        {
            Address passedAddress = (Address)obj;

            int compareValue = this.PostalCode.CompareTo(passedAddress.PostalCode);
            if (compareValue != 0)
            {
                return compareValue;
            }

            compareValue = this.Region.CompareTo(passedAddress.Region);
            if (compareValue != 0)
            {
                return compareValue;
            }

            compareValue = this.City.CompareTo(passedAddress.City);
            if (compareValue != 0)
            {
                return compareValue;
            }

            compareValue = this.Street.CompareTo(passedAddress.Street);
            if (compareValue != 0)
            {
                return compareValue;
            }
            return 0;
        }

        #endregion Methods

    }
}
