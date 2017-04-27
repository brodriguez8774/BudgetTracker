using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetTracker
{
    public class Entity
    {
        #region Variables

        protected Address address;              // Addess of entity.
        protected string category;              // Type of entity (person, company, etc).
        protected string firstName;             // "Main" name of entity.
        protected string lastName;              // "Optional"/additonal name of entity. Leave blank for companies, etc.
        protected long phoneNumber;             // Contact phone number.

        #endregion Variables

        #region Constructors

        /// <summary>
        /// Constructor for a person entity.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="phoneNumber"></param>
        public Entity(string category, string firstName, string lastName, Address address, long phoneNumber)
        {
            Category = category;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Constructor for a company entity.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="phoneNumber"></param>
        public Entity(string category, string firstName, Address address, long phoneNumber)
        {
            Category = category;
            FirstName = firstName;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        #endregion Constructors

        #region Properties

        public string Category
        {
            get { return category; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("category", "Invalid category. Value is null.");
                }
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Invalid category. Value is empty.", "category");
                }
                category = value;
            }
        }

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
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("address", "Invalid address. Value is null.");
                }
                address = value;
            }
        }

        public long PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.ToString().Length < 10)
                {
                    throw new ArgumentOutOfRangeException("phoneNumber", "Invalid phone number. Value is less than 10 digits.");
                }
                if (value.ToString().Length > 10)
                {
                    throw new ArgumentOutOfRangeException("phoneNumber", "Invalid phone number. Value is more than 10 digits.");
                }
                phoneNumber = value;
            }
        }

        #endregion Properties

        #region Methods



        #endregion Methods

    }
}
