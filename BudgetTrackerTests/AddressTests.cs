using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BudgetTracker;

namespace BudgetTrackerTests
{
    [TestClass]
    public class AddressTests
    {

        #region Variables

        private string firstName;
        private string firstNameNull;
        private string firstNameEmpty;
        private string lastName;
        private string lastNameNull;
        private string lastNameEmpty;
        private string street;
        private string streetNull;
        private string streetEmpty;
        private string city;
        private string cityNull;
        private string cityEmpty;
        private string region;
        private string regionNull;
        private string regionEmpty;
        private int postalCode;
        private int postalCodeSmall;
        private int postalCodeLarge;

        #endregion Variables

        [TestInitialize]
        public void Initialize() {
            firstName = "Test First Name";
            firstNameEmpty = "";
            lastName = "Test Last Name";
            lastNameEmpty = "";
            street = "Test Street";
            streetEmpty = "";
            city = "Test City";
            cityEmpty = "";
            region = "Test Region";
            regionEmpty = "";
            postalCode = 12345;
            postalCodeSmall = 99;
            postalCodeLarge = 1000000000;
        }

        #region Model Creation Tests

        [TestMethod]
        public void Test_AddressCreation_Good()
        {
            BudgetTracker.Address address = new Address(firstName, lastName, street, city, region, postalCode);
            Assert.AreEqual(firstName, address.FirstName);
            Assert.AreEqual(lastName, address.LastName);
            Assert.AreEqual(street, address.Street);
            Assert.AreEqual(city, address.City);
            Assert.AreEqual(region, address.Region);
            Assert.AreEqual(postalCode, address.PostalCode);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Invalid first name. Value is null.")]
        public void Test_AddressCreation_FirstNameNull()
        {
            BudgetTracker.Address address = new Address(firstNameNull, lastName, street, city, region, postalCode);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid first name. Value is empty.")]
        public void Test_AddressCreation_FirstNameEmpty() {
            BudgetTracker.Address address = new Address(firstNameEmpty, lastName, street, city, region, postalCode);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Invalid last name. Value is null.")]
        public void Test_AddressCreation_LastNameNull()
        {
            BudgetTracker.Address address = new Address(firstName, lastNameNull, street, city, region, postalCode);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid last name. Value is empty.")]
        public void Test_AddressCreation_LastNameEmpty()
        {
            BudgetTracker.Address address = new Address(firstName, lastNameEmpty, street, city, region, postalCode);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Invalid street. Value is null.")]
        public void Test_AddressCreation_StreetNull()
        {
            BudgetTracker.Address address = new Address(firstName, lastName, streetNull, city, region, postalCode);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid street. Value is empty.")]
        public void Test_AddressCreation_StreetEmpty()
        {
            BudgetTracker.Address address = new Address(firstName, lastName, streetEmpty, city, region, postalCode);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Invalid city. Value is null.")]
        public void Test_AddressCreation_CityNull()
        {
            BudgetTracker.Address address = new Address(firstName, lastName, street, cityNull, region, postalCode);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid city. Value is empty.")]
        public void Test_AddressCreation_CityEmpty()
        {
            BudgetTracker.Address address = new Address(firstName, lastName, street, cityEmpty, region, postalCode);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Invalid region. Value is null.")]
        public void Test_AddressCreation_RegionNull()
        {
            BudgetTracker.Address address = new Address(firstName, lastName, street, city, regionNull, postalCode);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid region. Value is empty.")]
        public void Test_AddressCreation_RegionEmpty()
        {
            BudgetTracker.Address address = new Address(firstName, lastName, street, city, regionEmpty, postalCode);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Invalid postal code. Value should be 3 or more digits.")]
        public void Test_AddressCreation_PostalCodeSmall()
        {
            BudgetTracker.Address address = new Address(firstName, lastName, street, city, region, postalCodeSmall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Invalid postal code. Value should be 10 or less digits.")]
        public void Test_AddressCreation_PostalCodeLarge()
        {
            BudgetTracker.Address address = new Address(firstName, lastName, street, city, region, postalCodeLarge);
        }

        #endregion Model Creation Tests

    }
}
