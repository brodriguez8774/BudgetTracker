using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BudgetTracker.DataStructures;


namespace BudgetTrackerTests.DataStructures
{
    [TestClass]
    public class GenericNodeTests
    {
        #region Variables

        int zeroInt;
        int oneInt;
        int negOneInt;
        string nullString;
        string emptyString;
        string testString1;
        string testString2;
        string testString3;

        #endregion Variables

        [TestInitialize]
        public void Initialize()
        {
            zeroInt = 0;
            oneInt = 1;
            negOneInt = -1;
            emptyString = "";
            testString1 = "Test";
            testString2 = "Testing";
            testString3 = "Tested";
        }


        [TestMethod]
        public void Test_GenericNodeMethod_CompareTo_Int_Equal()
        {
            GenericNode<int> intNode1 = new GenericNode<int>();
            intNode1.Data = zeroInt;

            int compareValue = intNode1.CompareTo(intNode1);
            Assert.AreEqual(0, compareValue);
        }


        [TestMethod]
        public void Test_GenericNodeMethod_CompareTo_Int_Differs()
        {
            GenericNode<int> intNode1 = new GenericNode<int>();
            GenericNode<int> intNode2 = new GenericNode<int>();
            GenericNode<int> intNode3 = new GenericNode<int>();
            intNode1.Data = zeroInt;
            intNode2.Data = oneInt;
            intNode3.Data = negOneInt;

            int compareValue = intNode1.CompareTo(intNode2);
            Assert.AreEqual(-1, compareValue);
            compareValue = intNode2.CompareTo(intNode1);
            Assert.AreEqual(1, compareValue);

            // TODO: Currently breaks if negatives are introduced. Gives inverse of expected values.
            testString1 = intNode1.Data.ToString();
            testString2 = intNode2.Data.ToString();
            testString3 = intNode3.Data.ToString();

            
            compareValue = intNode2.CompareTo(intNode3);
            Assert.AreEqual(1, compareValue);
            compareValue = intNode3.CompareTo(intNode2);
            Assert.AreEqual(-1, compareValue);
        }


        [TestMethod]
        public void Test_GenericNodeMethod_CompareTo_Decimal_Equal()
        {
            GenericNode<decimal> decimalNode1 = new GenericNode<decimal>();
            decimalNode1.Data = 123.4m;
            int compareValue = decimalNode1.CompareTo(decimalNode1);
            Assert.AreEqual(0, compareValue);
        }


        [TestMethod]
        public void Test_GenericNodeMethod_CompareTo_Decimal_Differs()
        {
            GenericNode<decimal> decimalNode1 = new GenericNode<decimal>();
            GenericNode<decimal> decimalNode2 = new GenericNode<decimal>();
            decimalNode1.Data = 123.4m;
            decimalNode2.Data = 123m;
            int compareValue = decimalNode1.CompareTo(decimalNode2);
            Assert.AreEqual(1, compareValue);
            compareValue = decimalNode2.CompareTo(decimalNode1);
            Assert.AreEqual(-1, compareValue);

            decimalNode2.Data = 123.5m;
            compareValue = decimalNode1.CompareTo(decimalNode2);
            Assert.AreEqual(-1, compareValue);
            compareValue = decimalNode2.CompareTo(decimalNode1);
            Assert.AreEqual(1, compareValue);

            decimalNode2.Data = 124.4m;
            compareValue = decimalNode1.CompareTo(decimalNode2);
            Assert.AreEqual(-1, compareValue);
            compareValue = decimalNode2.CompareTo(decimalNode1);
            Assert.AreEqual(1, compareValue);
        }


        [TestMethod]
        public void Test_GenericNodeMethod_CompareTo_String_Equal()
        {
            GenericNode<string> stringNode1 = new GenericNode<string>();
            stringNode1.Data = testString1;
            int compareValue = stringNode1.CompareTo(stringNode1);
            Assert.AreEqual(0, compareValue);
        }


        [TestMethod]
        public void Test_GenericeNodeMethod_CompareTo_String_Differs()
        {
            GenericNode<string> stringNode1 = new GenericNode<string>();
            GenericNode<string> stringNode2 = new GenericNode<string>();
            GenericNode<string> stringNode3 = new GenericNode<string>();
            stringNode1.Data = emptyString;
            stringNode2.Data = testString2;
            stringNode3.Data = testString3;

            int compareValue = stringNode1.CompareTo(stringNode2);
            Assert.AreEqual(-1, compareValue);
            compareValue = stringNode2.CompareTo(stringNode1);
            Assert.AreEqual(1, compareValue);

            stringNode1.Data = testString1;
            compareValue = stringNode2.CompareTo(stringNode3);
            Assert.AreEqual(1, compareValue);
            compareValue = stringNode3.CompareTo(stringNode2);
            Assert.AreEqual(-1, compareValue);
        }


        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Test_GenericNodeMethod_CompareTo_NullString()
        {
            GenericNode<string> stringNode1 = new GenericNode<string>();
            GenericNode<string> stringNode2 = new GenericNode<string>();
            stringNode1.Data = nullString;
            stringNode2.Data = emptyString;

            stringNode2.CompareTo(stringNode1);
        }
    }
}
