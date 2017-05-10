using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BudgetTracker.Models;


namespace BudgetTrackerTests.Models
{
    [TestClass]
    public class EntityTests
    {
        #region Variables

        private Address address;
        private Address addressNull;
        private Region region;

        private string category;
        private string categoryNull;
        private string categoryEmpty;
        private string firstName;
        private string firstNameNull;
        private string firstNameEmpty;
        private string lastName;
        private string lastNameNull;
        private string lastNameEmpty;
        private string companyName;
        private long phoneNumber;
        private long phoneNumberSmall;
        private long phoneNumberLarge;

        #endregion Variables

        [TestInitialize]
        public void Initialize()
        {
            region = new Region(0, "Test Region");
            address = new Address("Test Street", "Test City", region, 12345);

            category = "Test Category";
            categoryEmpty = "";
            firstName = "Test First Name";
            firstNameEmpty = "";
            lastName = "Test Last Name";
            lastNameEmpty = "";
            companyName = "Test Company Name";
            phoneNumber = 1234567890;
            phoneNumberSmall = 123456789;
            phoneNumberLarge = 12345678901;
        }

        #region Class Creation Tests

        #region Constructor Tests

        [TestMethod]
        public void Test_EntityCreation_PersonConstructor_Good()
        {
            Entity entity = new Entity(category, firstName, lastName, address, phoneNumber);
            Assert.AreEqual(category, entity.Category);
            Assert.AreEqual(firstName, entity.FirstName);
            Assert.AreEqual(lastName, entity.LastName);
            Assert.AreEqual(address, entity.Address);
            Assert.AreEqual(phoneNumber, entity.PhoneNumber);
        }

        [TestMethod]
        public void Test_EntityCreation_CompanyConstructor_Good()
        {
            Entity entity = new Entity(category, companyName, address, phoneNumber);
            Assert.AreEqual(category, entity.Category);
            Assert.AreEqual(companyName, entity.FirstName);
            Assert.AreEqual(address, entity.Address);
            Assert.AreEqual(phoneNumber, entity.PhoneNumber);
        }

        #endregion ConstructorTests

        #region Class Property Tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_EntityCreation_CategoryNull()
        {
            Entity entity = new Entity(categoryNull, firstName, lastName, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_EntityCreation_CategoryEmpty()
        {
            Entity entity = new Entity(categoryEmpty, firstName, lastName, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_EntityCreation_FirstNameNull()
        {
            Entity entity = new Entity(category, firstNameNull, lastName, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_EntityCreation_FirstNameEmpty()
        {
            Entity entity = new Entity(category, firstNameEmpty, lastName, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_EntityCreation_LastNameNull()
        {
            Entity entity = new Entity(category, firstName, lastNameNull, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_EntityCreation_LastNameEmpty()
        {
            Entity entity = new Entity(category, firstName, lastNameEmpty, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_EntityCreation_AddressNull()
        {
            Entity entity = new Entity(category, firstName, lastName, addressNull, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_EntityCreation_PhoneNumberSmall()
        {
            Entity entity = new Entity(category, firstName, lastName, address, phoneNumberSmall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_EntityCreation_PhoneNumberLarge()
        {
            Entity entity = new Entity(category, firstName, lastName, address, phoneNumberLarge);
        }

        #endregion Class Property Tests

        #endregion Class Creation Tests

    }
}
