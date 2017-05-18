using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BudgetTracker.Models;


namespace BudgetTrackerTests.Models
{
    [TestClass]
    public class RepeatingTransactionTests
    {
        #region Variables

        private Address address;
        private Entity paymentFrom;
        private Entity paymentTo;
        private Transaction transaction;
        private Transaction transcationNull;

        private int frequency;
        private int frequencyZero;
        private int frequencyNegative;
        private DateTime dateStart;
        private DateTime dateStartDefault;
        private DateTime dateEnd;
        private DateTime dateEndDefault;

        private readonly DateTime dateToday = DateTime.Today;
        private readonly DateTime dateTomorrow = DateTime.Today.AddDays(1);
        private readonly DateTime dateYesterday = DateTime.Today.AddDays(-1);
        private readonly DateTime dateNextWeek = DateTime.Today.AddDays(7);
        private readonly DateTime dateLastWeek = DateTime.Today.AddDays(-7);

        #endregion Variables

        [TestInitialize]
        public void Initialize()
        {
            address = new Address("Test Street", "Test City", "Test Region", 12345);
            paymentFrom = new Entity("Test Category", "Test First Name", "Test Last Name", address, 5555555555);
            paymentTo = new Entity("Test Category", "Test Name", address, 5555555555);

            frequency = 7;
            frequencyZero = 0;
            frequencyNegative = -7;
            dateStart = dateToday;
            dateEnd = dateNextWeek;
        }

        #region Class Creation Tests

        #region Constructor Tests

        [TestMethod]
        public void Test_RepeatingTransactionCreation_NoEndDate_Good()
        {
            RepeatingTransaction repeatingTransaction = new RepeatingTransaction(frequency, dateStart, paymentFrom, paymentTo);
            Assert.AreEqual(frequency, repeatingTransaction.Frequency);
            Assert.AreEqual(dateStart, repeatingTransaction.DateStart);
            Assert.AreEqual(paymentFrom, repeatingTransaction.PaymentFrom);
            Assert.AreEqual(paymentTo, repeatingTransaction.PaymentTo);
        }


        [TestMethod]
        public void Test_RepeatingTransactionCreation_HasEndDate_Good()
        {
            RepeatingTransaction repeatingTransaction = new RepeatingTransaction(frequency, dateStart, dateEnd, paymentFrom, paymentTo);
            Assert.AreEqual(frequency, repeatingTransaction.Frequency);
            Assert.AreEqual(dateStart, repeatingTransaction.DateStart);
            Assert.AreEqual(dateEnd, repeatingTransaction.DateEnd);
            Assert.AreEqual(paymentFrom, repeatingTransaction.PaymentFrom);
            Assert.AreEqual(paymentTo, repeatingTransaction.PaymentTo);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_RepeatingTransactionCreation_StartDateEqualsEndDate()
        {
            dateStart = dateToday;
            dateEnd = dateToday;
            RepeatingTransaction repeatingTransaction = new RepeatingTransaction(frequency, dateStart, dateEnd, paymentFrom, paymentTo);
            Assert.AreEqual(frequency, repeatingTransaction.Frequency);
            Assert.AreEqual(dateStart, repeatingTransaction.DateStart);
            Assert.AreEqual(dateEnd, repeatingTransaction.DateEnd);
            Assert.AreEqual(paymentFrom, repeatingTransaction.PaymentFrom);
            Assert.AreEqual(paymentTo, repeatingTransaction.PaymentTo);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_RepeatingTransactionCreation_StartDateAfterEndDate()
        {
            dateStart = dateNextWeek;
            dateEnd = dateLastWeek;
            RepeatingTransaction repeatingTransaction = new RepeatingTransaction(frequency, dateStart, dateEnd, paymentFrom, paymentTo);
            Assert.AreEqual(frequency, repeatingTransaction.Frequency);
            Assert.AreEqual(dateStart, repeatingTransaction.DateStart);
            Assert.AreEqual(dateEnd, repeatingTransaction.DateEnd);
            Assert.AreEqual(paymentFrom, repeatingTransaction.PaymentFrom);
            Assert.AreEqual(paymentTo, repeatingTransaction.PaymentTo);
        }

        #endregion Constructor Tests



        #region Class Property Tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_RepeatingTransactionCreation_FrequencyZero()
        {
            RepeatingTransaction repeatingTransaction = new RepeatingTransaction(frequencyZero, dateStart, dateEnd, paymentFrom, paymentTo);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_RepeatingTransactionCreation_FrequencyNegative()
        {
            RepeatingTransaction repeatingTransaction = new RepeatingTransaction(frequencyNegative, dateStart, dateEnd, paymentFrom, paymentTo);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_RepeatingTransactionCreation_DateStartDefault()
        {
            RepeatingTransaction repeatingTransaction = new RepeatingTransaction(frequency, dateStartDefault, dateEnd, paymentFrom, paymentTo);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_RepeatingTransactionCreation_DateEndDefault()
        {
            RepeatingTransaction repeatingTransaction = new RepeatingTransaction(frequency, dateStart, dateEndDefault, paymentFrom, paymentTo);
        }

        #endregion Class Property Tests

        #endregion Class Creation Tests



        #region Method Tests

        [TestMethod]
        public void Test_RepeatingTransactionMethod_CompareTo_Equal()
        {
            RepeatingTransaction repeatingTransaction = new RepeatingTransaction(frequency, dateStart, dateEnd, paymentFrom, paymentTo);
            int compareValue = repeatingTransaction.CompareTo(repeatingTransaction);
            Assert.AreEqual(0, compareValue);
        }


        [TestMethod]
        public void Test_RepeatingTransactionMethod_CompareTo_Equal_EmptyDateEnd()
        {
            RepeatingTransaction repeatingTransaction = new RepeatingTransaction(frequency, dateStart, paymentFrom, paymentTo);
            int compareValue = repeatingTransaction.CompareTo(repeatingTransaction);
            Assert.AreEqual(0, compareValue);
        }


        [TestMethod]
        public void Test_REpeatingTransactionMethod_CompareTo_DateStartDiffers()
        {
            RepeatingTransaction repeatingTransactionSmaller = new RepeatingTransaction(frequency, dateYesterday, dateEnd, paymentFrom, paymentTo);
            RepeatingTransaction repeatingTransactionLarger = new RepeatingTransaction(frequency, dateTomorrow, dateEnd, paymentFrom, paymentTo);
            int comparevalue = repeatingTransactionSmaller.CompareTo(repeatingTransactionLarger);
            Assert.AreEqual(-1, comparevalue);
            comparevalue = repeatingTransactionLarger.CompareTo(repeatingTransactionSmaller);
            Assert.AreEqual(1, comparevalue);
        }


        [TestMethod]
        public void Test_RepeatingTransactionMethod_CompareTo_DateEndDiffers()
        {
            RepeatingTransaction repeatingTransactionSmaller = new RepeatingTransaction(frequency, dateStart, dateTomorrow, paymentFrom, paymentTo);
            RepeatingTransaction repeatingTransactionLarger = new RepeatingTransaction(frequency, dateStart, dateNextWeek, paymentFrom, paymentTo);
            int comparevalue = repeatingTransactionSmaller.CompareTo(repeatingTransactionLarger);
            Assert.AreEqual(-1, comparevalue);
            comparevalue = repeatingTransactionLarger.CompareTo(repeatingTransactionSmaller);
            Assert.AreEqual(1, comparevalue);
        }


        [TestMethod]
        public void Test_RepeatingTransactionMethod_CompareTo_TransactionListDiffers()
        {
            RepeatingTransaction repeatingTransactionSmaller = new RepeatingTransaction(2, dateStart, dateEnd, paymentFrom, paymentTo);
            RepeatingTransaction repeatingTransactionLarger = new RepeatingTransaction(1, dateStart, dateEnd, paymentFrom, paymentTo);
            //repeatingTransactionSmaller.TransactionList
            int comparevalue = repeatingTransactionSmaller.CompareTo(repeatingTransactionLarger);
            Assert.AreEqual(-1, comparevalue);
            comparevalue = repeatingTransactionLarger.CompareTo(repeatingTransactionSmaller);
            Assert.AreEqual(1, comparevalue);
        }


        [TestMethod]
        public void Test_RepeatingTransactionMethod_CompleteTransaction_IndexValues() {
            RepeatingTransaction repeatingTransaction = new RepeatingTransaction(frequency, dateStart, paymentFrom, paymentTo);
            Assert.AreEqual(-1, repeatingTransaction.LastCompletedTransactionIndex);
            repeatingTransaction.CompleteTransaction("First Transaction", 15.99m, dateToday.AddMinutes(-20));
            Assert.AreEqual(0, repeatingTransaction.LastCompletedTransactionIndex);
            repeatingTransaction.CompleteTransaction("Second Transaction", 1m, dateToday);
            Assert.AreEqual(1, repeatingTransaction.LastCompletedTransactionIndex);

            // Tested on null, n, and n+1 items. Should work on all further values.
        }


        [TestMethod]
        public void Test_RepeatingTransactionMethod_CompleteTransaction_NodeValues()
        {
            RepeatingTransaction repeatingTransaction = new RepeatingTransaction(frequency, dateStart, paymentFrom, paymentTo);
            Assert.IsNull(repeatingTransaction.TransactionList.FirstNode.Data.Description);
            Assert.AreEqual(0m, repeatingTransaction.TransactionList.FirstNode.Data.TransactionAmount);
            Assert.AreEqual(DateTime.MinValue, repeatingTransaction.TransactionList.FirstNode.Data.DateProcessed);
            repeatingTransaction.CompleteTransaction("First Transaction", 15.99m, dateToday.AddMinutes(-20));
            Assert.AreEqual("First Transaction", repeatingTransaction.TransactionList.FirstNode.Data.Description);
            Assert.AreEqual(15.99m, repeatingTransaction.TransactionList.FirstNode.Data.TransactionAmount);
            Assert.AreEqual(dateToday.AddMinutes(-20), repeatingTransaction.TransactionList.FirstNode.Data.DateProcessed);
            repeatingTransaction.CompleteTransaction("Second Transaction", 1m, dateToday);
            Assert.AreEqual("Second Transaction", repeatingTransaction.TransactionList.FirstNode.Next.Data.Description);
            Assert.AreEqual(1m, repeatingTransaction.TransactionList.FirstNode.Next.Data.TransactionAmount);
            Assert.AreEqual(dateToday, repeatingTransaction.TransactionList.FirstNode.Next.Data.DateProcessed);

            // Tested on null, n, and n+1 items. Should work on all further values.
        }

        #endregion Method Tests
    }
}
