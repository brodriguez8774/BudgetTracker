using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.DataStructures
{
    public class ComboItem
    {
        #region Variables

        protected ulong id;                     // Id for comboItem.
        protected IComparable itemValue;        // Value for comboitem.

        #endregion Variables;



        #region Constructors

        public ComboItem(ulong id, IComparable itemValue)
        {
            ID = id;
            ItemValue = itemValue;
        }

        #endregion Constructors



        #region Properties

        /// <summary>
        /// Id for comboItem
        /// </summary>
        public ulong ID
        {
            get { return id; }
            set { id = value; }
        }


        /// <summary>
        /// Value for comboItem to hold.
        /// </summary>
        public IComparable ItemValue
        {
            get { return itemValue; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("itemValue", "Invalid itemValue. Value is null.");
                }
                itemValue = value;
            }
        }

        #endregion Properties



        #region Methods

        /// <summary>
        /// Override for default ToString.
        /// Returns itemValue as string.
        /// </summary>
        /// <returns>ItemValue as string.</returns>
        public override string ToString()
        {
            return itemValue.ToString();
        }

        #endregion Methods
    }
}
