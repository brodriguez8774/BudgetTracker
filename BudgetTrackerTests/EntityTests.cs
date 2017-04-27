using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BudgetTracker;


namespace BudgetTrackerTests
{
    [TestClass]
    public class EntityTests
    {
        #region Variables

        Address address;
        Address addressNull;

        private string category;
        private string categoryNull;
        private string categoryEmpty;
        private string firstName;
        private string firstNameNull;
        private string firstNameEmpty;
        private string lastName;
        private string lastNameNull;
        private string lastNameEmpty;
        private long phoneNumber;
        private long phoneNumberSmall;
        private long phoneNumberLarge;

        #endregion Variables

        [TestInitialize]
        public void Initialize()
        {
            address = new Address("Test Street", "Test City", "Test Region", 12345);

            category = "Test Category";
            categoryEmpty = "";
            firstName = "Test First Name";
            firstNameEmpty = "";
            lastName = "Test Last Name";
            lastNameEmpty = "";
            phoneNumber = 1234567890;
            phoneNumberSmall = 123456789;
            phoneNumberLarge = 12345678901;
        }

        #region Model Creation Tests

        [TestMethod]
        public void Test_EntityCreation_Good()
        {
            Entity entityObject = new Entity(category, firstName, lastName, address, phoneNumber);
            Assert.AreEqual(category, entityObject.Category);
            Assert.AreEqual(firstName, entityObject.FirstName);
            Assert.AreEqual(lastName, entityObject.LastName);
            Assert.AreEqual(address, entityObject.Address);
            Assert.AreEqual(phoneNumber, entityObject.PhoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_EntityCreation_CategoryNull()
        {
            Entity entityObject = new Entity(categoryNull, firstName, lastName, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_EntityCreation_CategoryEmpty()
        {
            Entity entityObject = new Entity(categoryEmpty, firstName, lastName, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_EntityCreation_FirstNameNull()
        {
            Entity entityObject = new Entity(category, firstNameNull, lastName, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_EntityCreation_FirstNameEmpty()
        {
            Entity entityObject = new Entity(category, firstNameEmpty, lastName, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_EntityCreation_LastNameNull()
        {
            Entity entityObject = new Entity(category, firstName, lastNameNull, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_EntityCreation_LastNameEmpty()
        {
            Entity entityObject = new Entity(category, firstName, lastNameEmpty, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_EntityCreation_AddressNull()
        {
            Entity entityObject = new Entity(category, firstName, lastName, addressNull, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_EntityCreation_PhoneNumberSmall()
        {
            Entity entityObject = new Entity(category, firstName, lastName, address, phoneNumberSmall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_EntityCreation_PhoneNumberLarge()
        {
            Entity entityObject = new Entity(category, firstName, lastName, address, phoneNumberLarge);
        }

        #endregion Model Creation Tests

    }
}
