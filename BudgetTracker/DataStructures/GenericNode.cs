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
    public class GenericNode<T>
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
    }
}
