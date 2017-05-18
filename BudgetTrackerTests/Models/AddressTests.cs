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



        #region Initialization

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

        #endregion Initialization



        #region Constructor Tests

        [TestMethod]
        public void Test_Address_Constructor()
        {
            Address address = new Address(street, city, region, postalCode);

            Assert.AreEqual(street, address.Street);
            Assert.AreEqual(city, address.City);
            Assert.AreEqual(region, address.Region);
            Assert.AreEqual(postalCode, address.PostalCode);
        }

        #endregion Constructor Tests



        #region Property Tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Address_Property_Street_Null()
        {
            Address address = new Address(streetNull, city, region, postalCode);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Address_Property_Street_Empty()
        {
            Address address = new Address(streetEmpty, city, region, postalCode);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Address_Property_City_Null()
        {
            Address address = new Address(street, cityNull, region, postalCode);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Address_Property_City_Empty()
        {
            Address address = new Address(street, cityEmpty, region, postalCode);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Address_Property_Region_Null()
        {
            Address address = new Address(street, city, regionNull, postalCode);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Address_Property_Region_Empty()
        {
            Address address = new Address(street, city, regionEmpty, postalCode);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Address_Property_PostalCode_Small()
        {
            Address address = new Address(street, city, region, postalCodeSmall);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_Address_Property_PostalCode_Large()
        {
            Address address = new Address(street, city, region, postalCodeLarge);
        }

        #endregion Property Tests



        #region Method Tests

        [TestMethod]
        public void Test_Address_Method_CompareTo_Equal()
        {
            Address address = new Address("Test Street", "Test City", "Test Region", 12345);
            int compareValue = address.CompareTo(address);
            Assert.AreEqual(0, compareValue);
        }


        [TestMethod]
        public void Test_Address_Method_CompareTo_StreetDiffers()
        {
            Address addressSmaller = new Address("Test Street 1", "Test City", "Test Region", 12345);
            Address addressLarger = new Address("Test Street 2", "Test City", "Test Region", 12345);
            int compareValue = addressSmaller.CompareTo(addressLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = addressLarger.CompareTo(addressSmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        public void Test_Address_Method_CompareTo_CityDiffers()
        {
            Address addressSmaller = new Address("Test Street", "Test City 1", "Test Region", 12345);
            Address addressLarger = new Address("Test Street", "Test City 2", "Test Region", 12345);
            int compareValue = addressSmaller.CompareTo(addressLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = addressLarger.CompareTo(addressSmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        public void Test_Address_Method_CompareTo_RegionDiffers()
        {
            Address addressSmaller = new Address("Test Street", "Test City", "Test Region 1", 12345);
            Address addressLarger = new Address("Test Street", "Test City", "Test Region 2", 12345);
            int compareValue = addressSmaller.CompareTo(addressLarger);
            Assert.AreEqual(-1, compareValue);
            compareValue = addressLarger.CompareTo(addressSmaller);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        public void Test_Address_Method_CompareTo_PostalCodeDiffers()
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
        public void Test_Address_Method_CompareTo_InvalidType()
        {
            Address address = new Address("Test Street", "Test City", "Test Region", 12345);
            string otherType = "Other Type";
            address.CompareTo(otherType);
        }

        #endregion Method Tests
    }
}
