using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetTracker.DataStructures
{
    /// <summary>
    /// Node for use with GenericLinkedList.
    /// </summary>
    /// <typeparam name="T">Generic Datatype</typeparam>
    public class GenericNode<T> : IComparable
    {
        #region Properties

        /// <summary>
        /// Generic datatype for linked list to hold.
        /// </summary>
        public T Data
        {
            get;
            set;
        }

        /// <summary>
        /// Next node in linked list.
        /// </summary>
        public GenericNode<T> Next
        {
            get;
            set;
        }

        /// <summary>
        /// Previous node in linked list.
        /// </summary>
        public GenericNode<T> Previous
        {
            get;
            set;
        }

        #endregion Properties



        #region Methods

        /// <summary>
        /// Compares GenericNode objects by comparing respective data fields, as strings.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            GenericNode<T> passedNode = (GenericNode<T>)obj;
            bool thisIsNumberBool;
            bool passedIsNumberBool;
            int compareValue;
            decimal thisDecimal;
            decimal passedDecimal;

            // Try to convert this.Data to decimal. If no error, then is of number type.
            try
            {
                Decimal.Parse(this.Data.ToString().Trim());
                thisIsNumberBool = true;
            }
            catch
            {
                thisIsNumberBool = false;
            }

            // Try to convert passed.Data to decimal. If no error, then is of number type.
            try
            {
                Decimal.Parse(passedNode.Data.ToString().Trim());
                passedIsNumberBool = true;
            }
            catch
            {
                passedIsNumberBool = false;
            }

            // If both Data types are number data types
            if (thisIsNumberBool && passedIsNumberBool)
            {
                thisDecimal = Decimal.Parse(this.Data.ToString().Trim());
                passedDecimal = Decimal.Parse(passedNode.Data.ToString().Trim());
                if (thisDecimal < passedDecimal)
                {
                    return -1;
                }
                else if (thisDecimal > passedDecimal)
                {
                    return 1;
                }
            }
            else
            {
                // Not a number data type. Thus compare using basic string comparisons.
                compareValue = this.Data.ToString().Trim().CompareTo(passedNode.Data.ToString().Trim());
                if (compareValue != 0)
                {
                    return compareValue;
                }
            }

            return 0;
        }


        /// <summary>
        /// Converts class to user-friendly string.
        /// </summary>
        /// <returns>User-friendly string of class.</returns>
        public override string ToString()
        {
            return (Data.ToString());
        }

        #endregion Methods
    }
}
