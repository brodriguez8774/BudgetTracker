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

        #endregion Properties

        #region Methods



        #endregion Methods

    }
}
