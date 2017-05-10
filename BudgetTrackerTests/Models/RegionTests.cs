using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BudgetTracker.Models;


namespace BudgetTrackerTests.Models
{
    [TestClass]
    public class RegionTests
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
            text = "Test Region";
        }

        #region Class Creation Tests

        [TestMethod]
        public void Test_RegionCreation_Good()
        {
            Region region = new Region(id, text);
            Assert.AreEqual(id, region.ID);
            Assert.AreEqual(text, region.Text);
        }

        #region Class Property Tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_RegionCreation_TextNull()
        {
            Region region = new Region(id, textNull);
        }

        #endregion

        #endregion Class Creation Tests
    }
}
