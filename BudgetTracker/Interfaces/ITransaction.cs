using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BudgetTracker.Models;


namespace BudgetTracker.Interfaces
{
    /// <summary>
    /// Requirements for any given type of transaction.
    /// </summary>
    interface ITransaction : IComparable
    {
        Entity PaymentFrom { get; set; }            // Entity making payment.

        Entity PaymentTo { get; set; }              // Entity being paid.

        string Description { get; set; }            // Description of payment.

        decimal TransactionAmount { get; set; }     // Amount of transaction.

        DateTime DateProcessed { get; set; }        // Date payment occured (if it has).

    }
}
