using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BudgetTracker.DataStructures;


namespace BudgetTrackerTests.DataStructures
{
    [TestClass]
    public class GenericLinkedListTests
    {
        #region Variables

        GenericLinkedList<int> linkedList;
        GenericNode<int> node;

        int zeroInt;
        int oneInt;
        int negOneInt;
        Boolean testBool;

        #endregion Variables



        #region Initialization

        [TestInitialize]
        public void Initialize()
        {
            zeroInt = 0;
            oneInt = 1;
            negOneInt = -1;
        }

        #endregion Initialization



        #region Constructor Tests

        [TestMethod]
        public void Test_GenericLinkedList_Constructor()
        {
            linkedList = new GenericLinkedList<int>();
            Assert.IsNotNull(linkedList);
            Assert.IsNull(linkedList.CurrentNode);
            Assert.IsNull(linkedList.FirstNode);
            Assert.IsNull(linkedList.LastNode);
        }

        #endregion Constructor Tests



        #region Method Tests

        public void Test_GenericLinkedList_Method_CompareTo()
        {
            GenericLinkedList<string> linkedList1 = new GenericLinkedList<string>();
            GenericLinkedList<string> linkedList2 = new GenericLinkedList<string>();

            linkedList1.PushLast("Cat");
            linkedList2.PushLast("Cat");
            int compareValue = linkedList1.CompareTo(linkedList2);
            Assert.AreEqual(0, compareValue);

            linkedList2.PushLast("Dog");
            compareValue = linkedList1.CompareTo(linkedList2);
            Assert.AreEqual(-1, compareValue);
            compareValue = linkedList2.CompareTo(linkedList1);
            Assert.AreEqual(1, compareValue);
        }
        

        #region Add Method

        [TestMethod]
        public void Test_GenericLinkedList_Method_Add_SuccessOnlyFirstIndex()
        {
            linkedList = new GenericLinkedList<int>();
            testBool = linkedList.Add(zeroInt, 0);
            Assert.IsTrue(testBool);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Data);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode);
            testBool = linkedList.Add(oneInt, 0);
            Assert.IsTrue(testBool);
            Assert.AreEqual(oneInt, linkedList.FirstNode.Data);
            Assert.AreEqual(zeroInt, linkedList.LastNode.Data);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode.Previous);
            Assert.AreEqual(linkedList.LastNode, linkedList.FirstNode.Next);
            testBool = linkedList.Add(negOneInt, 0);
            Assert.IsTrue(testBool);
            Assert.AreEqual(negOneInt, linkedList.FirstNode.Data);
            Assert.AreEqual(oneInt, linkedList.FirstNode.Next.Data);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Next.Next.Data);
            Assert.AreEqual(zeroInt, linkedList.LastNode.Data);
            Assert.AreEqual(oneInt, linkedList.LastNode.Previous.Data);
            Assert.AreEqual(negOneInt, linkedList.LastNode.Previous.Previous.Data);
        }


        [TestMethod]
        public void Test_GenericLinkedList_Method_Add_SuccessOnlyLastIndex()
        {
            linkedList = new GenericLinkedList<int>();
            testBool = linkedList.Add(zeroInt, 0);
            Assert.IsTrue(testBool);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Data);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode);
            testBool = linkedList.Add(oneInt, 1);
            Assert.IsTrue(testBool);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Data);
            Assert.AreEqual(oneInt, linkedList.LastNode.Data);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode.Previous);
            Assert.AreEqual(linkedList.LastNode, linkedList.FirstNode.Next);
            testBool = linkedList.Add(negOneInt, 2);
            Assert.IsTrue(testBool);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Data);
            Assert.AreEqual(oneInt, linkedList.FirstNode.Next.Data);
            Assert.AreEqual(negOneInt, linkedList.FirstNode.Next.Next.Data);
            Assert.AreEqual(negOneInt, linkedList.LastNode.Data);
            Assert.AreEqual(oneInt, linkedList.LastNode.Previous.Data);
            Assert.AreEqual(zeroInt, linkedList.LastNode.Previous.Previous.Data);
        }


        [TestMethod]
        public void Test_GenericLinkedList_Method_Add_BadIndexEmptyList()
        {
            linkedList = new GenericLinkedList<int>();
            testBool = linkedList.Add(zeroInt, 1);
            Assert.IsFalse(testBool);
            Assert.IsNull(linkedList.FirstNode);
            Assert.IsNull(linkedList.LastNode);
            testBool = linkedList.Add(zeroInt, -1);
            Assert.IsFalse(testBool);
            Assert.IsNull(linkedList.FirstNode);
            Assert.IsNull(linkedList.LastNode);
        }


        [TestMethod]
        public void Test_GenericLinkedList_Method_Add_BadIndex()
        {
            linkedList = new GenericLinkedList<int>();
            testBool = linkedList.Add(zeroInt, 0);
            Assert.IsTrue(testBool);
            testBool = linkedList.Add(oneInt, 1);
            Assert.IsTrue(testBool);
            testBool = linkedList.Add(negOneInt, 2);
            Assert.IsTrue(testBool);
            testBool = linkedList.Add(zeroInt, 4);
            Assert.IsFalse(testBool);
            testBool = linkedList.Add(zeroInt, -1);
            Assert.IsFalse(testBool);
        }

        #endregion Add Method


        #region Retrieve Method

        [TestMethod]
        public void Test_GenericLinkedList_Method_Retrieve_Success()
        {
            linkedList = new GenericLinkedList<int>();
            linkedList.PushLast(zeroInt);
            linkedList.PushLast(oneInt);
            linkedList.PushLast(negOneInt);
            node = linkedList.Retrieve(0);
            Assert.AreEqual(zeroInt, node.Data);
            node = linkedList.Retrieve(1);
            Assert.AreEqual(oneInt, node.Data);
            node = linkedList.Retrieve(2);
            Assert.AreEqual(negOneInt, node.Data);
        }


        [TestMethod]
        public void Test_GenericLinkedList_Method_Retrieve_IndexTooLow()
        {
            linkedList = new GenericLinkedList<int>();
            node = linkedList.Retrieve(0);
            Assert.IsNull(node);
            linkedList.PushLast(zeroInt);
            node = linkedList.Retrieve(-1);
            Assert.IsNull(node);
        }


        [TestMethod]
        public void Test_GenericLinkedList_Method_Retrieve_IndexTooHigh()
        {
            linkedList = new GenericLinkedList<int>();
            node = linkedList.Retrieve(0);
            Assert.IsNull(node);
            linkedList.PushLast(zeroInt);
            node = linkedList.Retrieve(1);
            Assert.IsNull(node);
            linkedList.PushLast(oneInt);
            node = linkedList.Retrieve(2);
            Assert.IsNull(node);
        }

        #endregion Retrieve Method


        #region Remove Method

        [TestMethod]
        public void Test_GenericLinkedList_Method_Remove_SuccessOnlyFirstIndex()
        {
            linkedList = new GenericLinkedList<int>();
            linkedList.PushLast(zeroInt);
            linkedList.PushLast(oneInt);
            linkedList.PushLast(negOneInt);
            node = linkedList.Remove(0);
            Assert.IsNotNull(node);
            Assert.AreEqual(zeroInt, node.Data);
            Assert.IsNull(node.Next);
            Assert.IsNull(node.Previous);
            Assert.AreEqual(oneInt, linkedList.FirstNode.Data);
            Assert.AreEqual(negOneInt, linkedList.LastNode.Data);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode.Previous);
            Assert.AreEqual(linkedList.LastNode, linkedList.FirstNode.Next);
            node = linkedList.Remove(0);
            Assert.IsNotNull(node);
            Assert.AreEqual(oneInt, node.Data);
            Assert.IsNull(node.Next);
            Assert.IsNull(node.Previous);
            Assert.AreEqual(negOneInt, linkedList.FirstNode.Data);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode);
            node = linkedList.Remove(0);
            Assert.IsNotNull(node);
            Assert.AreEqual(negOneInt, node.Data);
            Assert.IsNull(node.Next);
            Assert.IsNull(node.Previous);
            Assert.IsNull(linkedList.FirstNode);
            Assert.IsNull(linkedList.LastNode);
        }


        [TestMethod]
        public void Test_GenericLinkedList_Method_Remove_SuccessOnlyLastIndex()
        {
            linkedList = new GenericLinkedList<int>();
            linkedList.PushLast(zeroInt);
            linkedList.PushLast(oneInt);
            linkedList.PushLast(negOneInt);
            node = linkedList.Remove(2);
            Assert.IsNotNull(node);
            Assert.AreEqual(negOneInt, node.Data);
            Assert.IsNull(node.Next);
            Assert.IsNull(node.Previous);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Data);
            Assert.AreEqual(oneInt, linkedList.LastNode.Data);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode.Previous);
            Assert.AreEqual(linkedList.LastNode, linkedList.FirstNode.Next);
            node = linkedList.Remove(1);
            Assert.IsNotNull(node);
            Assert.AreEqual(oneInt, node.Data);
            Assert.IsNull(node.Next);
            Assert.IsNull(node.Previous);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Data);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode);
            node = linkedList.Remove(0);
            Assert.IsNotNull(node);
            Assert.AreEqual(zeroInt, node.Data);
            Assert.IsNull(node.Next);
            Assert.IsNull(node.Previous);
            Assert.IsNull(linkedList.FirstNode);
            Assert.IsNull(linkedList.LastNode);
        }


        [TestMethod]
        public void Test_GenericLinkedList_Method_Remove_IndexTooHigh()
        {
            linkedList = new GenericLinkedList<int>();
            node = linkedList.Remove(0);
            Assert.IsNull(node);
            linkedList.PushLast(0);
            node = linkedList.Remove(1);
            Assert.IsNull(node);
            linkedList.PushLast(0);
            node = linkedList.Remove(2);
            Assert.IsNull(node);

            // Tested for 0, n, and n+1 items. Should be valued for all further values.
        }


        [TestMethod]
        public void Test_GenericLinkedList_Method_Remove_IndexTooLow()
        {
            linkedList = new GenericLinkedList<int>();
            node = linkedList.Remove(0);
            Assert.IsNull(node);
            linkedList.PushLast(0);
            node = linkedList.Remove(-1);
            Assert.IsNull(node);

            // Tested for n and n+1 items. Should be valid for all further values.
        }

        #endregion Remove Method


        #region Push/Pop Methods

        [TestMethod]
        public void Test_GenericLinkedList_Method_PushFirst_Success()
        {
            linkedList = new GenericLinkedList<int>();

            // Test push to empty list.
            linkedList.PushFirst(zeroInt);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Data);
            Assert.AreEqual(zeroInt, linkedList.LastNode.Data);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Test push to list with one item.
            linkedList.PushFirst(oneInt);
            Assert.AreEqual(oneInt, linkedList.FirstNode.Data);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Next.Data);
            Assert.AreEqual(linkedList.LastNode, linkedList.FirstNode.Next);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Test push to list with two items.
            linkedList.PushFirst(negOneInt);
            Assert.AreEqual(negOneInt, linkedList.FirstNode.Data);
            Assert.AreEqual(oneInt, linkedList.FirstNode.Next.Data);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Next.Next.Data);
            Assert.AreEqual(linkedList.LastNode.Previous, linkedList.FirstNode.Next);
            Assert.AreEqual(linkedList.LastNode, linkedList.FirstNode.Next.Next);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Tested on null, n, and n+1 items. Should work on all further values.
        }


        [TestMethod]
        public void Test_GenericLinkedList_Method_PopFirst_Success()
        {
            linkedList = new GenericLinkedList<int>();
            linkedList.PushFirst(zeroInt);
            linkedList.PushFirst(oneInt);
            linkedList.PushFirst(negOneInt);

            // Test pop on list with three items.
            node = linkedList.PopFirst();
            Assert.IsNotNull(node);
            Assert.AreEqual(zeroInt, linkedList.LastNode.Data);
            Assert.AreEqual(oneInt, linkedList.FirstNode.Data);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Test pop on list with two items.
            node = linkedList.PopFirst();
            Assert.IsNotNull(node);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Data);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Test pop on list with one item.
            node = linkedList.PopFirst();
            Assert.IsNotNull(node);
            Assert.IsNull(linkedList.FirstNode);
            Assert.IsNull(linkedList.LastNode);

            // Tested on 1, 1+1, and 1+2 items. Should work on all further n+1 values.
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_GenericLinkedList_Method_PopFirst_EmptyList()
        {
            linkedList = new GenericLinkedList<int>();
            node = linkedList.PopFirst();
        }


        [TestMethod]
        public void Test_GenericLinkedList_Method_PushLast_Success()
        {
            linkedList = new GenericLinkedList<int>();

            // Test push to empty list.
            linkedList.PushLast(zeroInt);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Data);
            Assert.AreEqual(zeroInt, linkedList.LastNode.Data);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Test push to list with one item.
            linkedList.PushLast(oneInt);
            Assert.AreEqual(oneInt, linkedList.LastNode.Data);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Data);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode.Previous);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Test push to list with two items.
            linkedList.PushLast(negOneInt);
            Assert.AreEqual(negOneInt, linkedList.LastNode.Data);
            Assert.AreEqual(oneInt, linkedList.LastNode.Previous.Data);
            Assert.AreEqual(zeroInt, linkedList.LastNode.Previous.Previous.Data);
            Assert.AreEqual(linkedList.FirstNode.Next, linkedList.LastNode.Previous);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode.Previous.Previous);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Tested on null, n, and n+1 items. Should work on all further values.
        }


        [TestMethod]
        public void Test_GenericLinkedList_Method_PopLast_Success()
        {
            linkedList = new GenericLinkedList<int>();
            linkedList.PushLast(zeroInt);
            linkedList.PushLast(oneInt);
            linkedList.PushLast(negOneInt);

            // Test pop on list with three items.
            node = linkedList.PopLast();
            Assert.IsNotNull(node);
            Assert.AreEqual(oneInt, linkedList.LastNode.Data);
            Assert.AreEqual(zeroInt, linkedList.LastNode.Previous.Data);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Test pop on list with two items.
            node = linkedList.PopLast();
            Assert.IsNotNull(node);
            Assert.AreEqual(zeroInt, linkedList.LastNode.Data);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Test pop on list with one item.
            node = linkedList.PopLast();
            Assert.IsNotNull(node);
            Assert.IsNull(linkedList.FirstNode);
            Assert.IsNull(linkedList.LastNode);

            // Tested on 1, 1+1, and 1+2 items. Should work on all further n+1 values.
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_GenericLinkedList_Method_PopLast_EmptyList()
        {
            linkedList = new GenericLinkedList<int>();
            node = linkedList.PopLast();
        }

        #endregion Push/Pop Methods


        #region Queuing methods

        [TestMethod]
        public void Test_GenericLinkedList_Method_Enqueue_Success()
        {
            linkedList = new GenericLinkedList<int>();

            // Test enqueue to empty list.
            linkedList.Enqueue(zeroInt);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Data);
            Assert.AreEqual(zeroInt, linkedList.LastNode.Data);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Test enqueue to list with one item.
            linkedList.Enqueue(oneInt);
            Assert.AreEqual(oneInt, linkedList.LastNode.Data);
            Assert.AreEqual(zeroInt, linkedList.FirstNode.Data);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode.Previous);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Test enqueue to list with two items.
            linkedList.Enqueue(negOneInt);
            Assert.AreEqual(negOneInt, linkedList.LastNode.Data);
            Assert.AreEqual(oneInt, linkedList.LastNode.Previous.Data);
            Assert.AreEqual(zeroInt, linkedList.LastNode.Previous.Previous.Data);
            Assert.AreEqual(linkedList.FirstNode.Next, linkedList.LastNode.Previous);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode.Previous.Previous);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Tested on null, n, and n+1 items. Should work on all further values.
        }


        [TestMethod]
        public void Test_GenericLinkedList_Method_Dequeue_Success()
        {
            linkedList = new GenericLinkedList<int>();
            linkedList.Enqueue(zeroInt);
            linkedList.Enqueue(oneInt);
            linkedList.Enqueue(negOneInt);

            // Test dequeue on list with three items.
            node = linkedList.Dequeue();
            Assert.IsNotNull(node);
            Assert.AreEqual(oneInt, linkedList.FirstNode.Data);
            Assert.AreEqual(negOneInt, linkedList.LastNode.Data);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Test dequeue on list with two items.
            node = linkedList.Dequeue();
            Assert.IsNotNull(node);
            Assert.AreEqual(negOneInt, linkedList.FirstNode.Data);
            Assert.AreEqual(linkedList.FirstNode, linkedList.LastNode);
            Assert.IsNull(linkedList.FirstNode.Previous);
            Assert.IsNull(linkedList.LastNode.Next);

            // Test dequeue on list with one item.
            node = linkedList.Dequeue();
            Assert.IsNotNull(node);
            Assert.IsNull(linkedList.FirstNode);
            Assert.IsNull(linkedList.LastNode);

            // Tested on 1, 1+1, and 1+2 items. Should work on all further n+1 values.
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_GenericLinkedList_Method_Dequeue_EmptyList()
        {
            linkedList = new GenericLinkedList<int>();
            node = linkedList.Dequeue();
        }

        #endregion Queuing Methods

        #endregion Method Tests
    }
}
