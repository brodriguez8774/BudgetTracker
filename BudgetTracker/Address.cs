using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetTracker
{
    public class Address
    {
        #region Variables

        private string street;
        private string city;
        private string region;
        private int postalCode;

        #endregion Variables

        #region Constructors

        public Address(string street, string city, string region, int postalCode)
        {
            Street = street;
            City = city;
            Region = region;
            PostalCode = postalCode;
        }

        #endregion Constructors

        #region Properties

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

        public string Region
        {
            get { return region; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("region", "Invalid street. Value is null.");
                }
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Invalid street. Value is empty.", "region");
                }
                region = value;
            }
        }

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



        #endregion Methods

    }
}
