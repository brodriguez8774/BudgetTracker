using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BudgetTracker.DataStructures;


namespace BudgetTrackerTests.DataStructures
{
    [TestClass]
    public class ComboItemTests
    {
        #region Variables

        private ulong id;
        private string itemValue;
        private string itemValueNull;

        #endregion Variables



        #region Initialization

        [TestInitialize]
        public void Initialize()
        {
            id = 0;
            itemValue = "Test Text";
        }

        #endregion Initialization



        #region Constructor Tests

        [TestMethod]
        public void Test_ComboItem_Constructor()
        {
            ComboItem comboItem = new ComboItem(id, itemValue);
            Assert.AreEqual(id, comboItem.ID);
            Assert.AreEqual(itemValue, comboItem.ItemValue);
        }

        #endregion Constructor Tests



        #region Property Tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_ComboItem_Property_ItemValueNull()
        {
            ComboItem comboItem = new ComboItem(id, itemValueNull);
        }

        #endregion Property Tests
    }
}
