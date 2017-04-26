using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetTracker
{
    public class Person
    {

        #region Variables

        private string firstName;
        private string lastName;
        private Address address;
        private int phoneNumber;

        #endregion Variables

        #region Constructors

        public Person(string firstName, string lastName, Address address, int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        #endregion Constructors

        #region Properties

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("firstName", "Invalid first name. Value is null.");
                }
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Invalid first name. Value is empty.", "firstName");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("lastName", "Invalid last name. Value is null.");
                }
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Invalid last name. Value is empty.", "lastName");
                }
                lastName = value;
            }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set {
                if (value.ToString().Length < 10)
                {
                    throw new ArgumentOutOfRangeException("phoneNumber", "Invalid phone number. Value is less than 10 digits.");
                }
                phoneNumber = value;
            }
        }

        #endregion Properties

        #region Methods



        #endregion Methods

    }
}
