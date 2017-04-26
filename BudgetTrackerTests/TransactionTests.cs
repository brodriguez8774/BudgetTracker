using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BudgetTracker;


namespace BudgetTrackerTests
{
    [TestClass]
    public class TransactionTests
    {
        #region Variables

        DateTime dateToday = DateTime.Today;
        DateTime dateTomorrow = DateTime.Today.AddDays(1);
        DateTime dateYesterday = DateTime.Today.AddDays(-1);

        private string description;
        private string descriptionNull;
        private string descriptionEmpty;
        private DateTime dateProcessed;
        private DateTime dateProcessedDefault;
        private DateTime dateProcessedFuture;
        private DateTime dateDue;
        private DateTime dateDueDefault;
        private decimal transactionAmount;

        #endregion Variables

        [TestInitialize]
        public void Initialize()
        {
            description = "Test Description";
            descriptionEmpty = "";
            dateProcessed = dateToday;
            dateProcessedFuture = dateTomorrow;
            dateDue = dateToday;
            transactionAmount = 123.0m;
        }

         #region Model Creation Tests

        [TestMethod]
        public void Test_TransactionCreation_Good()
        {
            Transaction transaction = new Transaction(description, dateProcessed, dateDue, transactionAmount);
            Assert.AreEqual(description, transaction.Description);
            Assert.AreEqual(dateProcessed, transaction.DateProcessed);
            Assert.AreEqual(dateDue, transaction.DateDue);
            Assert.AreEqual(transactionAmount, transaction.TransactionAmount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_TransactionCreation_DescriptionNull()
        {
            Transaction transaction = new Transaction(descriptionNull, dateProcessed, dateDue, transactionAmount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_TransactionCreation_DescriptionEmpty()
        {
            Transaction transaction = new Transaction(descriptionEmpty, dateProcessed, dateDue, transactionAmount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_TransactionCreation_DateProcessedDefault()
        {
            Transaction transaction = new Transaction(description, dateProcessedDefault, dateDue, transactionAmount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_TransactionCreation_DateProcessedInFuture()
        {
            Transaction transaction = new Transaction(description, dateProcessedFuture, dateDue, transactionAmount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_TransactionCreation_DateDueDefault()
        {
            Transaction transaction = new Transaction(description, dateProcessed, dateDueDefault, transactionAmount);
        }

        #endregion Model Creation Tests

    }
}
