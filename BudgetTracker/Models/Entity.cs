using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetTracker.Models
{
    /// <summary>
    /// An entity such as a person, business, company, etc which may handle transactions.
    /// </summary>
    public class Entity : IComparable
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

        /// <summary>
        /// Type of entity (person, company, etc).
        /// </summary>
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

        /// <summary>
        /// "Main" name of entity.
        /// </summary>
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

        /// <summary>
        /// "Optional"/additonal name of entity. Leave blank for companies, etc.
        /// </summary>
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

        /// <summary>
        /// Addess of entity.
        /// </summary>
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

        /// <summary>
        /// Contact phone number.
        /// </summary>
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

        /// <summary>
        /// Compares Entity objects using:
        /// category, firstName, and lastName.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            Entity passedEntity = (Entity)obj;

            int compareValue = this.Category.CompareTo(passedEntity.Category);
            if (compareValue != 0)
            {
                return compareValue;
            }

            compareValue = this.FirstName.CompareTo(passedEntity.FirstName);
            if (compareValue != 0)
            {
                return compareValue;
            }

            try
            {
                compareValue = this.LastName.CompareTo(passedEntity.LastName);
                if (compareValue != 0)
                {
                    return compareValue;
                }
            }
            catch
            {
                // Ensures method does not crash if last name field is empty.
            }

            return 0;
        }

        #endregion Methods
    }
}
