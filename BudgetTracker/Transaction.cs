using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class Transaction
    {
        #region Variables

        private string description;
        private DateTime dateProcessed;
        private DateTime dateDue;
        private decimal transactionAmount;

        #endregion Variables

        #region Constructors

        public Transaction(string description, DateTime dateProcessed, DateTime dateDue, decimal transactionAmount)
        {
            Description = description;
            DateProcessed = dateProcessed;
            DateDue = dateDue;
            TransactionAmount = transactionAmount;
        }

        #endregion Constructors

        #region Properties

        public string Description
        {
            get { return description; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("description", "Invalid description. Value is null.");
                }
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Invalid description. Value is empty.");
                }
                description = value;
            }
        }

        public DateTime DateProcessed
        {
            get { return dateProcessed; }
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new ArgumentException("dateProcessed", "Invalid date processed. Value is null.");
                }
                if (value.CompareTo(DateTime.Today) > 0)
                {
                    throw new ArgumentException("dateProcessed", "Invalide date processed. Value is in the future.");
                }
                dateProcessed = value;
            }
        }

        public DateTime DateDue
        {
            get { return dateDue; }
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new ArgumentException("dateDue", "Invalid date due. Value is null.");
                }
                dateDue = value;
            }
        }

        public decimal TransactionAmount
        {
            get { return transactionAmount; }
            set
            { transactionAmount = value; }
        }

        #endregion Properties

        #region Methods



        #endregion Methods

    }
}
