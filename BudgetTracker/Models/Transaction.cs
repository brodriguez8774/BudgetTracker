using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BudgetTracker.Interfaces;


namespace BudgetTracker.Models
{
    /// <summary>
    /// Generic transaction.
    /// Can be used as is for a single basic transaction, or extended for more complex transaction types.
    /// </summary>
    public class Transaction : ITransaction
    {
        #region Variables

        protected Entity paymentFrom;             // Entity making payment.
        protected Entity paymentTo;               // Entity being paid.

        protected string description;             // Description of payment.
        protected decimal transactionAmount;      // Amount of transaction.
        protected DateTime dateProcessed;         // Date payment occured (if it has).
        protected DateTime dateDue;               // Date payment is due.

        #endregion Variables



        #region Constructors

        /// <summary>
        /// Base constructor.
        /// </summary>
        /// <param name="paymentFrom"></param>
        /// <param name="paymentTo"></param>
        public Transaction(Entity paymentFrom, Entity paymentTo, DateTime dateDue)
        {
            PaymentFrom = paymentFrom;
            PaymentTo = paymentTo;
            DateDue = dateDue;
        }


        /// <summary>
        /// Full constructor for single transaction.
        /// </summary>
        /// <param name="paymentFrom"></param>
        /// <param name="paymentTo"></param>
        /// <param name="description"></param>
        /// <param name="transactionAmount"></param>
        /// <param name="dateProcessed"></param>
        /// <param name="dateDue"></param>
        public Transaction(Entity paymentFrom, Entity paymentTo, string description, decimal transactionAmount, DateTime dateProcessed, DateTime dateDue)
        {
            PaymentFrom = paymentFrom;
            PaymentTo = paymentTo;
            Description = description;
            TransactionAmount = transactionAmount;
            DateProcessed = dateProcessed;
            DateDue = dateDue;
        }

        #endregion Constructors



        #region Properties

        /// <summary>
        /// Entity making payment.
        /// </summary>
        public Entity PaymentFrom
        {
            get { return paymentFrom; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("paymentFrom", "Invalid payer. Value is null.");
                }
                paymentFrom = value;
            }
        }


        /// <summary>
        /// Entity being paid.
        /// </summary>
        public Entity PaymentTo
        {
            get { return paymentTo; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("paymentTo", "Invalid payee. Value is null.");
                }
                paymentTo = value;
            }
        }


        /// <summary>
        /// Description of payment.
        /// </summary>
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


        /// <summary>
        /// Amount of transaction.
        /// </summary>
        public decimal TransactionAmount
        {
            get { return transactionAmount; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("transactionAmount", "Invalid transaction amount. Value cannot be 0.");
                }
                transactionAmount = value;
            }
        }


        /// <summary>
        /// Date payment occured (if it has).
        /// </summary>
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


        /// <summary>
        /// Date payment is due.
        /// </summary>
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

        #endregion Properties



        #region Methods

        /// <summary>
        /// Compares Transaction objects using:
        /// dateProcessed, description, transactionAmount, paymentFrom, and paymentTo.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            Transaction passedTransaction = (Transaction)obj;

            int compareValue = this.DateProcessed.CompareTo(passedTransaction.DateProcessed);
            if (compareValue != 0)
            {
                return compareValue;
            }

            compareValue = this.Description.CompareTo(passedTransaction.Description);
            if (compareValue != 0)
            {
                return compareValue;
            }

            compareValue = this.TransactionAmount.CompareTo(passedTransaction.TransactionAmount);
            if (compareValue != 0)
            {
                return compareValue;
            }

            compareValue = this.PaymentFrom.CompareTo(passedTransaction.PaymentFrom);
            if (compareValue != 0)
            {
                return compareValue;
            }

            compareValue = this.PaymentTo.CompareTo(passedTransaction.PaymentTo);
            if (compareValue != 0)
            {
                return compareValue;
            }

            return 0;
        }


        /// <summary>
        /// Converts model to user-friendly string.
        /// </summary>
        /// <returns>User-friendly string of model.</returns>
        public override string ToString()
        {
            return (dateProcessed.ToString() + " " + Environment.NewLine +
                "From: " + paymentFrom.ToStringShort() + "  To: " + paymentTo.ToStringShort() + " " + Environment.NewLine +
                "Description: " + "  " + "Amount: " + transactionAmount.ToString());
        }


        /// <summary>
        /// Converts model to condensed user-friendly string.
        /// </summary>
        /// <returns>Condensed user-friendly string of model.</returns>
        public string ToStringShort()
        {
            return (dateProcessed.ToString() + transactionAmount.ToString());
        }

        #endregion Methods

    }
}
