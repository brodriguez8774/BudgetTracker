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



        #region Initialization

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
            companyName = "Test Company Name";
            phoneNumber = 1234567890;
            phoneNumberSmall = 123456789;
            phoneNumberLarge = 12345678901;
        }

        #endregion Initialization



        #region Constructor Tests

        [TestMethod]
        public void Test_Entity_Constructor_Person()
        {
            Entity entity = new Entity(category, firstName, lastName, address, phoneNumber);
            Assert.AreEqual(category, entity.Category);
            Assert.AreEqual(firstName, entity.FirstName);
            Assert.AreEqual(lastName, entity.LastName);
            Assert.AreEqual(address, entity.Address);
            Assert.AreEqual(phoneNumber, entity.PhoneNumber);
        }

        [TestMethod]
        public void Test_Entity_Constructor_Company()
        {
            Entity entity = new Entity(category, companyName, address, phoneNumber);
            Assert.AreEqual(category, entity.Category);
            Assert.AreEqual(companyName, entity.FirstName);
            Assert.AreEqual(address, entity.Address);
            Assert.AreEqual(phoneNumber, entity.PhoneNumber);
        }

        #endregion ConstructorTests



        #region Property Tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Entity_Property_Category_Null()
        {
            Entity entity = new Entity(categoryNull, firstName, lastName, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Entity_Property_Category_Empty()
        {
            Entity entity = new Entity(categoryEmpty, firstName, lastName, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Entity_Property_FirstName_Null()
        {
            Entity entity = new Entity(category, firstNameNull, lastName, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Entity_Property_FirstName_Empty()
        {
            Entity entity = new Entity(category, firstNameEmpty, lastName, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Entity_Property_LastName_Null()
        {
            Entity entity = new Entity(category, firstName, lastNameNull, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Entity_Property_LastName_Empty()
        {
            Entity entity = new Entity(category, firstName, lastNameEmpty, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Entity_Property_Address_Null()
        {
            Entity entity = new Entity(category, firstName, lastName, addressNull, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Entity_Property_PhoneNumber_Small()
        {
            Entity entity = new Entity(category, firstName, lastName, address, phoneNumberSmall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Entity_Property_PhoneNumber_Large()
        {
            Entity entity = new Entity(category, firstName, lastName, address, phoneNumberLarge);
        }

        #endregion Property Tests



        #region Method Tests

        [TestMethod]
        public void Test_Entity_Method_CompareTo_Equal() {
            Entity entity = new Entity("Test Category", "Test First Name", "Test Last Name", address, 1234567890);
            int compareValue = entity.CompareTo(entity);
            Assert.AreEqual(0, compareValue);
        }


        [TestMethod]
        public void Test_Entity_Method_CompareTo_Equal_EmptyLastName()
        {
            Entity entity = new Entity("Test Category", "Test First Name", address, 1234567890);
            int compareValue = entity.CompareTo(entity);
            Assert.AreEqual(0, compareValue);
        }


        [TestMethod]
        public void Test_Entity_Method_CompareTo_CategoryDiffers()
        {
            Entity entitySmaller = new Entity("Test Category 1", "Test First Name", "Test Last Name", address, 1234567890);
            Entity entityLarger = new Entity("Test Category 2", "Test First Name", "Test Last Name", address, 1234567890);
            int compareValue = entitySmaller.CompareTo(entityLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = entityLarger.CompareTo(entitySmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        public void Test_Entity_Method_CompareTo_FirstNameDiffers()
        {
            Entity entitySmaller = new Entity("Test Category", "Test First Name 1", "Test Last Name", address, 1234567890);
            Entity entityLarger = new Entity("Test Category", "Test First Name 2", "Test Last Name", address, 1234567890);
            int compareValue = entitySmaller.CompareTo(entityLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = entityLarger.CompareTo(entitySmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        public void Test_Entity_Method_CompareTo_LastNameDiffers()
        {
            Entity entitySmaller = new Entity("Test Category", "Test First Name", "Test Last Name 1", address, 1234567890);
            Entity entityLarger = new Entity("Test Category", "Test First Name", "Test Last Name 2", address, 1234567890);
            int compareValue = entitySmaller.CompareTo(entityLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = entityLarger.CompareTo(entitySmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void Test_Entity_Method_CompareTo_InvalidType()
        {
            Entity entity = new Entity("Test Category", "Test First Name", "Test Last Name", address, 1234567890);
            string otherType = "Other Type";
            entity.CompareTo(otherType);
        }

        #endregion Method Tests
    }
}
