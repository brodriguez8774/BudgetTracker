using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetTracker.Models
{
    /// <summary>
    /// Region model for use in an address.
    /// </summary>
    public class Region
    {
        #region Variables

        protected ulong id;             // ID of region.
        protected string text;        // Value of region.

        #endregion Variables



        #region Constructors

        /// <summary>
        /// Base constructor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="region"></param>
        public Region(ulong id, string text)
        {
            ID = id;
            Text = text;
        }

        #endregion Constructors



        #region Properties

        /// <summary>
        /// ID of region.
        /// </summary>
        public ulong ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Value of region.
        /// </summary>
        public string Text
        {
            get { return text; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("text", "Invalid text. Value is null.");
                }
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Invalid text. Value is empty.", "text");
                }
                text = value;
            }
        }

        #endregion Properties
    }
}
