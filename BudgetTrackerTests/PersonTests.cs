using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BudgetTracker;


namespace BudgetTrackerTests
{
    [TestClass]
    public class PersonTests
    {

        #region Variables

        private string firstName;
        private string firstNameNull;
        private string firstNameEmpty;
        private string lastName;
        private string lastNameNull;
        private string lastNameEmpty;
        Address address;
        private int phoneNumber;
        private int phoneNumberSmall;
        // phoneNumberLarge would be a long. No need to test.

        #endregion Variables

        [TestInitialize]
        public void Initialize()
        {
            string street = "Test Street";
            string city = "Test City";
            string region = "Test Region";
            int postalCode = 12345;
            address = new Address(street, city, region, postalCode);

            firstName = "Test First Name";
            firstNameEmpty = "";
            lastName = "Test Last Name";
            lastNameEmpty = "";
            phoneNumber = 1234567890;
            phoneNumberSmall = 123456789;
        }

        [TestMethod]
        public void Test_PersonCreation_Good()
        {
            Person person = new Person(firstName, lastName, address, phoneNumber);
            Assert.AreEqual(firstName, person.FirstName);
            Assert.AreEqual(lastName, person.LastName);
            Assert.AreEqual(address, person.Address);
            Assert.AreEqual(phoneNumber, person.PhoneNumber);
        }

        #region Model Creation Tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_PersonCreation_FirstNameNull()
        {
            Person person = new Person(firstNameNull, lastName, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_PersonCreation_FirstNameEmpty()
        {
            Person person = new Person(firstNameEmpty, lastName, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_PersonCreation_LastNameNull()
        {
            Person person = new Person(firstName, lastNameNull, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_PersonCreation_LastNameEmpty()
        {
            Person person = new Person(firstName, lastNameEmpty, address, phoneNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_PersonCreation_PhoneNumberSmall()
        {
            Person person = new Person(firstName, lastName, address, phoneNumberSmall);
        }

        #endregion Model Creation Tests

    }
}
