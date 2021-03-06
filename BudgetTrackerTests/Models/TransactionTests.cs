﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BudgetTracker.Models;


namespace BudgetTrackerTests.Models
{
    [TestClass]
    public class TransactionTests
    {
        #region Variables

        private Address address;
        private Entity paymentFrom;
        private Entity paymentFromNull;
        private Entity paymentTo;
        private Entity paymentToNull;

        private string description;
        private string descriptionNull;
        private string descriptionEmpty;
        private decimal transactionAmount;
        private decimal transactionAmountZero;
        private DateTime dateProcessed;
        private DateTime dateProcessedDefault;
        private DateTime dateProcessedFuture;
        private DateTime dateDue;
        private DateTime dateDueDefault;

        private readonly DateTime dateToday = DateTime.Today;
        private readonly DateTime dateTomorrow = DateTime.Today.AddDays(1);
        private readonly DateTime dateYesterday = DateTime.Today.AddDays(-1);

        #endregion Variables



        #region Initialization

        [TestInitialize]
        public void Initialize()
        {
            address = new Address("Test Street", "Test City", "Test Region", 555555);
            paymentFrom = new Entity("Test Person", "Test First Name", "Test Last Name", address, 5555555555);
            paymentTo = new Entity("Test Company", "Test Name", address, 5555555555);
            description = "Test Description";
            descriptionEmpty = "";
            transactionAmount = 123.0m;
            transactionAmountZero = 0m;
            dateProcessed = dateToday;
            dateProcessedFuture = dateTomorrow;
            dateDue = dateToday;
        }

        #endregion Initialization



        #region Constructor Tests

        [TestMethod]
        public void Test_Transaction_Constructor_Base()
        {
            Transaction transaction = new Transaction(paymentFrom, paymentTo, dateDue);
            Assert.AreEqual(paymentFrom, transaction.PaymentFrom);
            Assert.AreEqual(paymentTo, transaction.PaymentTo);
            Assert.AreEqual(dateDue, transaction.DateDue);
        }


        [TestMethod]
        public void Test_Transaction_Constructor_FullTransaction()
        {
            Transaction transaction = new Transaction(paymentFrom, paymentTo, description, transactionAmount, dateProcessed, dateDue);
            Assert.AreEqual(paymentFrom, transaction.PaymentFrom);
            Assert.AreEqual(paymentTo, transaction.PaymentTo);
            Assert.AreEqual(description, transaction.Description);
            Assert.AreEqual(dateProcessed, transaction.DateProcessed);
            Assert.AreEqual(dateDue, transaction.DateDue);
            Assert.AreEqual(transactionAmount, transaction.TransactionAmount);
        }

        #endregion Constructor Tests



        #region Property Tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Transaction_Property_PaymentFrom_Null()
        {
            Transaction transaction = new Transaction(paymentFromNull, paymentTo, description, transactionAmount, dateProcessed, dateDue);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Transaction_Property_PaymentTo_Null()
        {
            Transaction transaction = new Transaction(paymentFrom, paymentToNull, description, transactionAmount, dateProcessed, dateDue);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Transaction_Property_Description_Null()
        {
            Transaction transaction = new Transaction(paymentFrom, paymentTo, descriptionNull, transactionAmount, dateProcessed, dateDue);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Transaction_Property_Description_Empty()
        {
            Transaction transaction = new Transaction(paymentFrom, paymentTo, descriptionEmpty, transactionAmount, dateProcessed, dateDue);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Transaction_Property_TransactionAmount_Zero()
        {
            Transaction transaction = new Transaction(paymentFrom, paymentTo, description, transactionAmountZero, dateProcessed, dateDue);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Transaction_Property_DateProcessed_Default()
        {
            Transaction transaction = new Transaction(paymentFrom, paymentTo, description, transactionAmount, dateProcessedDefault, dateDue);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Transaction_Property_DateProcessed_InFuture()
        {
            Transaction transaction = new Transaction(paymentFrom, paymentTo, description, transactionAmount, dateProcessedFuture, dateDue);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Transaction_DateDue_Default()
        {
            Transaction transaction = new Transaction(paymentFrom, paymentTo, description, transactionAmount, dateProcessed, dateDueDefault);
        }

        #endregion Property Tests



        #region Method Tests

        [TestMethod]
        public void Test_Transaction_Method_CompareTo_Equal()
        {
            Transaction transaction = new Transaction(paymentFrom, paymentTo, "Test Description", 123.4m, dateProcessed, dateDue);
            int compareValue = transaction.CompareTo(transaction);
            Assert.AreEqual(0, compareValue);
        }


        [TestMethod]
        public void Test_Transaction_Method_CompareTo_DateProcessedDiffers()
        {
            Transaction transactionSmaller = new Transaction(paymentFrom, paymentTo, "Test Description", 123.4m, dateYesterday, dateDue);
            Transaction transactionLarger = new Transaction(paymentFrom, paymentTo, "Test Description", 123.4m, dateToday, dateDue);
            int compareValue = transactionSmaller.CompareTo(transactionLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = transactionLarger.CompareTo(transactionSmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        public void Test_Transaction_Method_CompareTo_DescriptionDiffers()
        {
            Transaction transactionSmaller = new Transaction(paymentFrom, paymentTo, "Test Description 1", 123.4m, dateProcessed, dateDue);
            Transaction transactionLarger = new Transaction(paymentFrom, paymentTo, "Test Description 2", 123.4m, dateProcessed, dateDue);
            int compareValue = transactionSmaller.CompareTo(transactionLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = transactionLarger.CompareTo(transactionSmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        public void Test_Transaction_Method_CompareTo_TransactionAmountDiffers()
        {
            Transaction transactionSmaller = new Transaction(paymentFrom, paymentTo, "Test Description", 123.4m, dateProcessed, dateDue);
            Transaction transactionLarger = new Transaction(paymentFrom, paymentTo, "Test Description", 123.5m, dateProcessed, dateDue);
            int compareValue = transactionSmaller.CompareTo(transactionLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = transactionLarger.CompareTo(transactionSmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        public void Test_Transaction_Method_CompareTo_PaymentFromDiffers()
        {
            Transaction transactionSmaller = new Transaction(paymentFrom, paymentTo, "Test Description", 123.4m, dateProcessed, dateDue);
            paymentFrom = new Entity("Test Person", "Test First Name 1", "Test Last Name", address, 5555555555);
            Transaction transactionLarger = new Transaction(paymentFrom, paymentTo, "Test Description", 123.4m, dateProcessed, dateDue);
            int compareValue = transactionSmaller.CompareTo(transactionLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = transactionLarger.CompareTo(transactionSmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        public void Test_Transaction_Method_CompareTo_PaymentToDiffers()
        {
            Transaction transactionSmaller = new Transaction(paymentFrom, paymentTo, "Test Description", 123.4m, dateProcessed, dateDue);
            paymentTo = new Entity("Test Company", "Test Name 1", address, 5555555555);
            Transaction transactionLarger = new Transaction(paymentFrom, paymentTo, "Test Description", 123.4m, dateProcessed, dateDue);
            int compareValue = transactionSmaller.CompareTo(transactionLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = transactionLarger.CompareTo(transactionSmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void Test_Transaction_Method_CompareTo_InvalidType()
        {
            Transaction transaction = new Transaction(paymentFrom, paymentTo, "Test Description", 123.4m, dateProcessed, dateDue);
            String otherType = "Other Type";
            transaction.CompareTo(otherType);
        }

        #endregion Method Tests
    }
}
