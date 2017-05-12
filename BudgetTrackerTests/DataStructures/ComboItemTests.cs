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

        [TestInitialize]
        public void Initialize()
        {
            id = 0;
            itemValue = "Test Text";
        }

        #region Class Creation Tests

        [TestMethod]
        public void Test_ComboItemCreation_Good()
        {
            ComboItem comboItem = new ComboItem(id, itemValue);
            Assert.AreEqual(id, comboItem.ID);
            Assert.AreEqual(itemValue, comboItem.ItemValue);
        }

        #region Class Property Tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_ComboItemCreation_ItemValueNull()
        {
            ComboItem comboItem = new ComboItem(id, itemValueNull);
        }

        #endregion

        #endregion Class Creation Tests
    }
}
