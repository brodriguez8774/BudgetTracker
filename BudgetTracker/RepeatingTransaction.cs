using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetTracker
{
    /// <summary>
    /// A transaction with a start date, that either repeats indefinitely or until a specified end date.
    /// </summary>
    public class RepeatingTransaction : Transaction
    {
        #region Variables

        protected int frequency;                // Frequency of how often transaction repeats, in days.
        protected DateTime dateStart;           // Date of first occurance. Used in reference with frequency.
        protected DateTime dateEnd;             // Date of last occurance, if there is one.

        protected LinkedList<Transaction> transactionAmount;    // Linked List of transaction occurances.

        #endregion Variables

        #region Constructors

        /// <summary>
        /// Constructor for payment with no end date.
        /// </summary>
        /// <param name="frequencyInt"></param>
        /// <param name="dateStart"></param>
        /// <param name="paymentFrom"></param>
        /// <param name="paymentTo"></param>
        /// <param name="description"></param>
        /// <param name="transactionAmount"></param>
        /// <param name="dateProcessed"></param>
        /// <param name="dateDue"></param>
        public RepeatingTransaction(int frequency, DateTime dateStart,
            Entity paymentFrom, Entity paymentTo)
            : base(paymentFrom, paymentTo)
        {
            Frequency = frequency;
            DateStart = dateStart;
        }

        /// <summary>
        /// Constructor for payment with end date.
        /// </summary>
        /// <param name="frequencyInt"></param>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <param name="paymentFrom"></param>
        /// <param name="paymentTo"></param>
        /// <param name="description"></param>
        /// <param name="transactionAmount"></param>
        /// <param name="dateProcessed"></param>
        /// <param name="dateDue"></param>
        public RepeatingTransaction(int frequency, DateTime dateStart, DateTime dateEnd,
            Entity paymentFrom, Entity paymentTo)
            : base(paymentFrom, paymentTo)
        {
            Frequency = frequency;
            DateStart = dateStart;
            DateEnd = dateEnd;
        }

        #endregion Constructors

        #region Properties

        public int Frequency
        {
            get { return frequency; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("frequency", "Invalid frequency. Value is 0.");
                }
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("frequency", "Invalid frequency. Value is negative.");
                }
                frequency = value;
            }
        }

        public DateTime DateStart
        {
            get { return dateStart; }
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new ArgumentException("Invalid date start. Value is null.");
                }
                dateStart = value;
            }
        }

        public DateTime DateEnd
        {
            get { return dateEnd; }
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new ArgumentException("Invalid date end. Value is null.");
                }
                dateEnd = value;
            }
        }

        #endregion Properties

        #region Methods



        #endregion Methods
    }
}
