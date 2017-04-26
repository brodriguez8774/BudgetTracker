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

        private string firstName;
        private string lastName;
        private string street;
        private string city;
        private string region;
        private int postalCode;

        #endregion Variables

        #region Constructors

        public Address(string firstname, string lastName, string street, string city, string region, int postalCode)
        {
            FirstName = firstname;
            LastName = lastName;
            Street = street;
            City = city;
            Region = region;
            PostalCode = postalCode;
        }

        #endregion Constructors

        #region Properties

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        public int PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        #endregion Properties

        #region Methods



        #endregion Methods

    }
}
