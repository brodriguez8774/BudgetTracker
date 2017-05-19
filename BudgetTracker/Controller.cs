using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BudgetTracker.Models;


namespace BudgetTracker
{
    public class Controller
    {
        #region Variables

        private static Controller controller;           // Singleton of this class.

        IComparable[] addressArray;
        IComparable[] entityArray;
        IComparable[] transactionArray;
        IComparable[] repeatingTransactionArray;

        int addressIndex;
        int entityIndex;
        int transactionIndex;
        int repeatingTransactionIndex;

        #endregion Variables



        #region Constructors

        /// <summary>
        /// Base constructor.
        /// </summary>
        public Controller()
        {
            addressArray =  new IComparable[10];
            entityArray = new IComparable[10];
            transactionArray = new IComparable[0];
            repeatingTransactionArray = new IComparable[0];
        }

        #endregion Constructors



        #region Properties

        /// <summary>
        /// Singleton to return controller class.
        /// </summary>
        /// <returns></returns>
        public static Controller Get()
        {
            if (controller == null)
            {
                controller = new Controller();
            }
            return controller;
        }

        #endregion Properties



        #region Methods

        #region Public Methods

        public Entity SaveTransactor(string category, string primaryName, string secondaryName, string phoneNumber, string street, string city, string region, string postalCode)
        {
            Address newAddress = new Address(street, city, region, Int32.Parse(postalCode));
            addressArray[addressIndex] = newAddress;
            addressIndex++;

            Entity newEntity;
            if (secondaryName.Length == 0)
            {
                newEntity = new Entity(category, primaryName, newAddress, long.Parse(phoneNumber));
            }
            else
            {
                newEntity = new Entity(category, primaryName, secondaryName, newAddress, long.Parse(phoneNumber));
            }
            entityArray[entityIndex] = newEntity;
            entityIndex++;

            return newEntity;
        }

        #endregion


        #region Private Methods

        private void CheckArraySize(IComparable[] arrayToCheck)
        {
            int arrayLength = arrayToCheck.Length;
            int index = 0;
            bool continueBool = true;

            if (continueBool && index < arrayLength)
            {
                if (arrayToCheck[index] != null)
                {
                    index++;
                }
                else
                {
                    EnlargeArray(arrayToCheck);
                    continueBool = false;
                }
            }
        }


        private IComparable[] EnlargeArray(IComparable[] arrayToCheck)
        {
            int arrayLength = Convert.ToInt32(arrayToCheck.Length * 1.5);
            IComparable[] newArray = new IComparable[arrayLength];

            for (int index = 0; index < arrayToCheck.Length; index++)
            {
                newArray[index] = arrayToCheck[index];
            }

            return newArray;
        }

        #endregion

        #endregion Methods

    }
}
