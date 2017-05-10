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
        private string text;
        private string textNull;

        #endregion Variables

        [TestInitialize]
        public void Initialize()
        {
            id = 0;
            text = "Test Text";
        }

        #region Class Creation Tests

        [TestMethod]
        public void Test_ComboItemCreation_Good()
        {
            ComboItem comboItem = new ComboItem(id, text);
            Assert.AreEqual(id, comboItem.ID);
            Assert.AreEqual(text, comboItem.Text);
        }

        #region Class Property Tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_ComboItemCreation_TextNull()
        {
            ComboItem comboItem = new ComboItem(id, textNull);
        }

        #endregion

        #endregion Class Creation Tests
    }
}
