using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BudgetTracker.DataStructures;


namespace BudgetTracker.Models
{
    /// <summary>
    /// A transaction with a start date, that either repeats indefinitely or until a specified end date.
    /// </summary>
    public class RepeatingTransaction : Transaction
    {
        #region Variables

        protected int frequency;                // Frequency of how often transaction repeats, in days.
        protected int lastCompletedTransactionIndex;    // Index of node with most recently completed transaction.
        protected DateTime dateStart;           // Date of first occurance. Used in reference with frequency.
        protected DateTime dateEnd;             // Date of last occurance, if there is one.

        protected GenericLinkedList<Transaction> transactionList;    // Linked List of transaction occurances.

        #endregion Variables



        #region Constructors

        /// <summary>
        /// Constructor for payment with no end date.
        /// </summary>
        /// <param name="frequency"></param>
        /// <param name="dateStart"></param>
        /// <param name="paymentFrom"></param>
        /// <param name="paymentTo"></param>
        public RepeatingTransaction(int frequency, DateTime dateStart,
            Entity paymentFrom, Entity paymentTo)
            : base(paymentFrom, paymentTo, dateStart)
        {
            Frequency = frequency;
            DateStart = dateStart;

            InitializeLinkedList();
        }


        /// <summary>
        /// Constructor for payment with end date.
        /// </summary>
        /// <param name="frequency"></param>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <param name="paymentFrom"></param>
        /// <param name="paymentTo"></param>
        public RepeatingTransaction(int frequency, DateTime dateStart, DateTime dateEnd,
            Entity paymentFrom, Entity paymentTo)
            : base(paymentFrom, paymentTo, dateStart)
        {
            if (dateStart.CompareTo(dateEnd) == 0)
            {
                throw new ArgumentException("Invalid date start and date end. Values are the same.");
            }
            if (dateStart.CompareTo(dateEnd) > 0)
            {
                throw new ArgumentException("Invalid date start and date end. Start date is after end date.");
            }
            Frequency = frequency;
            DateStart = dateStart;
            DateEnd = dateEnd;

            InitializeLinkedList();
        }

        #endregion Constructors



        #region Properties

        /// <summary>
        /// Frequency of how often transaction repeats, in days.
        /// </summary>
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


        /// <summary>
        /// Index of node with most recently completed transaction.
        /// </summary>
        public int LastCompletedTransactionIndex
        {
            get { return lastCompletedTransactionIndex; }
        }


        /// <summary>
        /// Date of first occurance. Used in reference with frequency.
        /// </summary>
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


        /// <summary>
        /// Date of last occurance, if there is one.
        /// </summary>
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


        /// <summary>
        /// Linked List of transaction occurances.
        /// </summary>
        public GenericLinkedList<Transaction> TransactionList
        {
            get { return transactionList; }
        }

        #endregion Properties



        #region Methods

        /// <summary>
        /// Initializes linked list of transaction occurances.
        /// </summary>
        private void InitializeLinkedList()
        {
            dateProcessed = dateStart;
            DateTime tempDateEnd = dateEnd;
            transactionList = new GenericLinkedList<Transaction>();
            transactionList.PushFirst(new Transaction(paymentFrom, paymentTo, dateProcessed));

            if (tempDateEnd == DateTime.MinValue)
            {
                tempDateEnd = DateTime.Today.AddMonths(12);
            }

            while (dateProcessed.CompareTo(tempDateEnd) < 0)
            {
                dateProcessed = dateProcessed.AddDays(frequency);
                transactionList.PushLast(new Transaction(paymentFrom, paymentTo, dateProcessed));
            }
            lastCompletedTransactionIndex = -1;
        }


        /// <summary>
        /// Finalizes the next transaction in the list.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="transactionAmount"></param>
        /// <param name="dateProcessed"></param>
        public void CompleteTransaction(string description, decimal transactionAmount, DateTime dateProcessed)
        {
            lastCompletedTransactionIndex++;
            transactionList.Retrieve(lastCompletedTransactionIndex).Data.Description = description;
            transactionList.Retrieve(lastCompletedTransactionIndex).Data.TransactionAmount = transactionAmount;
            transactionList.Retrieve(lastCompletedTransactionIndex).Data.DateProcessed = dateProcessed;
        }

        #endregion Methods
    }
}
