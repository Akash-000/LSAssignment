using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Utility
    {
        /// <summary>
        /// checks for repetition of records in the AddressBook
        /// </summary>
        /// <param name="ForRepetition">List of Names of the address book</param>
        /// <param name="Name">Name given by the user of add in the address book</param>
        public static void RepetitionCheck(HashSet<string> ForRepetition, string Name)
        {
            if (ForRepetition.Contains(Name))
                throw new DuplicateRecordException(Constants.DuplicateExceptionMessage);
            else
            {
                ForRepetition.Add(Name);
            }
        }
        /// <summary>
        /// Checks if the record to be updated is present in the address book
        /// Checks if given updated name is different from the previous record and updates the ForRepetition
        /// </summary>
        /// <param name="ForRepetition">List containing names of record in address book</param>
        /// <param name="Name">Name of record to be updated</param>
        /// <param name="UpdateName">Updated name of the record</param>
        public static void CheckUpdateFeasibility(HashSet<string> ForRepetition, string Name, string UpdateName)
        {
            if (!ForRepetition.Contains(Name))
            {
                throw new NoRecordFoundException(Constants.NoRecordFound);
            }
            if (Name != UpdateName && !ForRepetition.Contains(UpdateName))
            {
                ForRepetition.Remove(Name);
                ForRepetition.Add(UpdateName);
            }
        }
    }
}
