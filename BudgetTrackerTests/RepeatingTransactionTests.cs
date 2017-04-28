using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BudgetTracker;


namespace BudgetTrackerTests
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

        public void Test_RepeatingTransactionCreation_HasEndDate_Good()
        {
            RepeatingTransaction repeatingTransaction = new RepeatingTransaction(frequency, dateStart, dateEnd, paymentFrom, paymentTo);
            Assert.AreEqual(frequency, repeatingTransaction.Frequency);
            Assert.AreEqual(dateStart, repeatingTransaction.DateStart);
            Assert.AreEqual(dateEnd, repeatingTransaction.DateEnd);
            Assert.AreEqual(paymentFrom, repeatingTransaction.PaymentFrom);
            Assert.AreEqual(paymentTo, repeatingTransaction.PaymentTo);
        }

        #endregion Constructor Tests

        #region Class Proprety Tests

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

        #endregion Class Proprety Tests

        #endregion Class Creation Tests
    }
}
