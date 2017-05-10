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
        /// 
        /// </summary>
        public ulong ID
        {
            get { return id; }
            set { id = value; }
        }

        public IComparable ItemValue
        {
            get { return itemValue; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("itemValue", "Invalid itemValue. Value is null.");
                }
                if (value.ToString().Trim() == "")
                {
                    throw new ArgumentException("Invalid itemValue. Value is empty.", "itemValue");
                }
                itemValue = value;
            }
        }

        #endregion Properties



        #region Methods

        public override string ToString()
        {
            return this.itemValue.ToString();
        }

        #endregion Methods
    }
}
