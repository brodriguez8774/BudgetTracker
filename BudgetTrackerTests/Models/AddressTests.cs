using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BudgetTracker.Models;


namespace BudgetTrackerTests.Models
{
    [TestClass]
    public class AddressTests
    {
        #region Variables

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
        public void Initialize()
        {
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

        #region Class Creation Tests

        [TestMethod]
        public void Test_AddressCreation_Good()
        {
            Address address = new Address(street, city, region, postalCode);

            Assert.AreEqual(street, address.Street);
            Assert.AreEqual(city, address.City);
            Assert.AreEqual(region, address.Region);
            Assert.AreEqual(postalCode, address.PostalCode);
        }

        #region Class Property Tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_AddressCreation_StreetNull()
        {
            Address address = new Address(streetNull, city, region, postalCode);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_AddressCreation_StreetEmpty()
        {
            Address address = new Address(streetEmpty, city, region, postalCode);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_AddressCreation_CityNull()
        {
            Address address = new Address(street, cityNull, region, postalCode);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_AddressCreation_CityEmpty()
        {
            Address address = new Address(street, cityEmpty, region, postalCode);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_AddressCreation_RegionNull()
        {
            Address address = new Address(street, city, regionNull, postalCode);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_AddressCreation_RegionEmpty()
        {
            Address address = new Address(street, city, regionEmpty, postalCode);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_AddressCreation_PostalCodeSmall()
        {
            Address address = new Address(street, city, region, postalCodeSmall);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_AddressCreation_PostalCodeLarge()
        {
            Address address = new Address(street, city, region, postalCodeLarge);
        }

        #endregion Class Property Tests

        #endregion Class Creation Tests

        #region Method Tests

        [TestMethod]
        public void TestAddressMethod_CompareTo_Equal()
        {
            Address address = new Address("Test Street", "Test City", "Test Region", 12345);
            int compareValue = address.CompareTo(address);
            Assert.AreEqual(0, compareValue);
        }


        [TestMethod]
        public void Test_AddressMethod_CompareTo_StreetDiffers()
        {
            Address addressSmaller = new Address("Test Street 1", "Test City", "Test Region", 12345);
            Address addressLarger = new Address("Test Street 2", "Test City", "Test Region", 12345);
            int compareValue = addressSmaller.CompareTo(addressLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = addressLarger.CompareTo(addressSmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        public void Test_AddressMethod_CompareTo_CityDiffers()
        {
            Address addressSmaller = new Address("Test Street", "Test City 1", "Test Region", 12345);
            Address addressLarger = new Address("Test Street", "Test City 2", "Test Region", 12345);
            int compareValue = addressSmaller.CompareTo(addressLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = addressLarger.CompareTo(addressSmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        public void Test_AddressMethod_CompareTo_RegionDiffers()
        {
            Address addressSmaller = new Address("Test Street", "Test City", "Test Region 1", 12345);
            Address addressLarger = new Address("Test Street", "Test City", "Test Region 2", 12345);
            int compareValue = addressSmaller.CompareTo(addressLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = addressLarger.CompareTo(addressSmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        public void Test_AddressMethod_CompareTo_PostalCodeDiffers()
        {
            Address addressSmaller = new Address("Test Street", "Test City", "Test Region", 12345);
            Address addressLarger = new Address("Test Street", "Test City", "Test Region", 12346);
            int compareValue = addressSmaller.CompareTo(addressLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = addressLarger.CompareTo(addressSmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void Test_AddressMethod_CompareTo_InvalidType()
        {
            Address address = new Address("Test Street", "Test City", "Test Region", 12345);
            string otherType = "Other Type";
            address.CompareTo(otherType);
        }

        #endregion Method Tests

    }
}
