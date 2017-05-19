using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BudgetTracker.DataStructures
{
    /// <summary>
    /// Generic doubly-linked Linked List Class.
    /// Stack = Push/Pop.
    /// Queue = Enqueue/Dequeue.
    /// </summary>
    /// <typeparam name="T">Generic Datatype</typeparam>
    public class GenericLinkedList<T> :IComparable
    {
        #region Variables

        private GenericNode<T> currentNode;         // Pointer for current element in list.
        private GenericNode<T> firstNode;           // Pointer for first element in list.
        private GenericNode<T> lastNode;            // Pointer for last element in list.

        #endregion Variables



        #region Constructors

        /// <summary>
        /// Base Constructor.
        /// </summary>
        public GenericLinkedList()
        {
            firstNode = null;
        }

        #endregion Constructors



        #region Properties

        /// <summary>
        /// Currently selected node in Linked List.
        /// </summary>
        public GenericNode<T> CurrentNode
        {
            get { return currentNode; }
            set { currentNode = value; }
        }


        /// <summary>
        /// First node of Linked List.
        /// </summary>
        public GenericNode<T> FirstNode
        {
            get { return firstNode; }
            set { firstNode = value; }
        }


        /// <summary>
        /// Last node of Linked List.
        /// </summary>
        public GenericNode<T> LastNode
        {
            get { return lastNode; }
            set { lastNode = value; }
        }

        #endregion Properties



        #region Methods

        /// <summary>
        /// Compares GenericLinkedLists objects node values and list length.
        /// </summary>
        /// <param name="obj">Compare value of LinkedLists.</param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            GenericLinkedList<T> passedList = (GenericLinkedList<T>)obj;

            this.currentNode = this.firstNode;
            passedList.currentNode = passedList.firstNode;
            while (this.currentNode != null && passedList.currentNode != null)
            {
                int compareValue = this.currentNode.CompareTo(passedList.currentNode);
                if (compareValue != 0)
                {
                    return compareValue;
                }
                this.currentNode = this.currentNode.Next;
                passedList.currentNode = passedList.currentNode.Next;
            }

            if (this.currentNode == null && passedList.currentNode != null)
            {
                return -1;
            } else if (passedList.currentNode == null && this.currentNode != null) {
                return 1;
            }

            return 0;
        }


        /// <summary>
        /// Converts class to user-friendly string.
        /// </summary>
        /// <returns>User-friendly string of class.</returns>
        public override string ToString()
        {
            string tempString = "";
            currentNode = firstNode;
            while (currentNode != null)
            {
                if (tempString != "") {
                    tempString += ", ";
                }
                tempString += currentNode.ToString();
                currentNode = currentNode.Next;
            }
            return tempString;
        }


        /// <summary>
        /// Add new node to given index in Linked List.
        /// Returns true if success or false if failed.
        /// </summary>
        /// <param name="content">Data for new node.</param>
        /// <param name="index">Desired index of new node.</param>
        /// <returns>True if success. False if failed.</returns>
        public Boolean Add(T content, int index)
        {
            GenericNode<T> newNode = new GenericNode<T>();
            GenericNode<T> tempNode;
            GenericNode<T> nextNode;
            GenericNode<T> previousNode;

            // Chech index before desired and ensure valid. If so, node can be added so set nextNode and previousNode.
            tempNode = Retrieve(index - 1);
            if (tempNode == null && index != 0)
            {
                return false;
            }

            newNode.Data = content;

            // If list is empty.
            if (firstNode == null)
            {
                firstNode = newNode;
                lastNode = newNode;
            }
            else
            {
                nextNode = Retrieve(index);
                previousNode = tempNode;

                // Set nextNode properties.
                newNode.Next = nextNode;
                if (nextNode != null)
                {
                    nextNode.Previous = newNode;
                }
                else
                {
                    lastNode = newNode;
                }

                // Set previousNode properties.
                newNode.Previous = previousNode;
                if (previousNode != null)
                {
                    previousNode.Next = newNode;
                }
                else
                {
                    firstNode = newNode;
                }
            }

            return true;
        }


        /// <summary>
        /// Retrieve node from indicated index.
        /// Returns node if success or null if failed.
        /// </summary>
        /// <param name="index">Index of desired node.</param>
        /// <returns>Node at index. Null if index not found.</returns>
        public GenericNode<T> Retrieve(int index)
        {
            GenericNode<T> tempNode;

            int tempIndex = 0;

            // Check that provided index is valid.
            if (index < 0)
            {
                return null;
            }
            else
            {
                tempNode = firstNode;
            }

            // Loop through linked list until index is found.
            while (tempIndex < index && tempNode != null)
            {
                // Check that next node is not null (end of list).
                if (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                    tempIndex++;
                }
                else
                {
                    tempNode = null;
                }
            }

            currentNode = tempNode;
            return currentNode;
        }


        /// <summary>
        /// Remove node from indicated index.
        /// Returns node if success or null if failed.
        /// </summary>
        /// <param name="index">Index of desired node.</param>
        /// <returns>Removed node if success. Null node if failed.</returns>
        public GenericNode<T> Remove(int index)
        {
            GenericNode<T> removalNode = Retrieve(index);
            GenericNode<T> nextNode;
            GenericNode<T> previousNode;

            // Ensure node index was found.
            if (removalNode == null)
            {
                return removalNode;
            }

            // Set new properties.
            nextNode = removalNode.Next;
            previousNode = removalNode.Previous;
            if (nextNode != null)
            {
                nextNode.Previous = previousNode;
            }
            else
            {
                lastNode = previousNode;
            }

            if (previousNode != null)
            {
                previousNode.Next = nextNode;
            }
            else
            {
                firstNode = nextNode;
            }

            // Set removalNode properties.
            removalNode.Next = null;
            removalNode.Previous = null;

            return removalNode;
        }


        /// <summary>
        /// Add node to front of linked list.
        /// </summary>
        /// <param name="content">Data for new node.</param>
        public void PushFirst(T content)
        {
            GenericNode<T> newNode = new GenericNode<T>();
            newNode.Data = content;

            // Check if any nodes are populated yet.
            if (firstNode == null)
            {
                lastNode = newNode;
            }
            else
            {
                newNode.Next = firstNode;
                firstNode.Previous = newNode;
            }
            firstNode = newNode;
        }


        /// <summary>
        /// Remove node from front of linked list.
        /// Returns removed node.
        /// </summary>
        /// <returns>Removed node.</returns>
        public GenericNode<T> PopFirst()
        {
            GenericNode<T> tempNode;

            tempNode = firstNode;
            try
            {
                firstNode = firstNode.Next;
            }
            catch
            {
                throw new ArgumentException("Invalid action. Linked list is already empty.", "LinkedList.PopFirst()");
            }
            

            // If first node has value (not null).
            if (firstNode != null)
            {
                firstNode.Previous = null;
            }
            else
            {
                // Else, make last node null also.
                lastNode = null;
            }

            tempNode.Next = null;
            tempNode.Previous = null;
            return tempNode;
        }


        /// <summary>
        /// Add node to back of linked list.
        /// </summary>
        /// <param name="content">Data for new node.</param>
        public void PushLast(T content)
        {
            GenericNode<T> newNode = new GenericNode<T>();
            newNode.Data = content;

            // Check if any nodes are populated yet.
            if (firstNode == null)
            {
                firstNode = newNode;
            }
            else
            {
                newNode.Previous = lastNode;
                lastNode.Next = newNode;
            }
            lastNode = newNode;
        }


        /// <summary>
        /// Remove node from back of linked list.
        /// Returns removed node.
        /// </summary>
        /// <returns>Removed node.</returns>
        public GenericNode<T> PopLast()
        {
            GenericNode<T> tempNode;

            tempNode = lastNode;
            try
            {
                lastNode = lastNode.Previous;
            }
            catch
            {
                throw new ArgumentException("Invalid action. Linked list is already empty.", "LinkedList.PopLast()");
            }

            // If last node has value (not null).
            if (lastNode != null)
            {
                lastNode.Next = null;
            }
            else
            {
                // Else, make first node null also.
                firstNode = null;
            }
            return tempNode;
        }


        /// <summary>
        /// Push node to back of linked list (queue).
        /// </summary>
        /// <param name="content">Data for new node.</param>
        public void Enqueue(T content)
        {
            GenericNode<T> newNode = new GenericNode<T>();
            newNode.Data = content;

            // Check if any nodes are populated yet.
            if (firstNode == null)
            {
                firstNode = newNode;
            }
            else
            {
                lastNode.Next = newNode;
                newNode.Previous = lastNode;
            }
            lastNode = newNode;
        }


        /// <summary>
        /// Remove node from front of linked list (queue).
        /// Returns removed node.
        /// </summary>
        /// <returns>Removed node.</returns>
        public GenericNode<T> Dequeue()
        {
            GenericNode<T> tempNode;

            tempNode = firstNode;
            try
            {
                firstNode = firstNode.Next;
            }
            catch
            {
                throw new ArgumentException("Invalid action. Linked list is already empty.", "LinkedList.Dequeue()");
            }

            // If first node has value (not null).
            if (firstNode != null)
            {
                firstNode.Previous = null;
            }
            else
            {
                // Else, make last node null also.
                lastNode = null;
            }
            return tempNode;
        }

        #endregion Methods
    }
}
