using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class DeleteRecord
    {
        /// <summary>
        /// Finds and delete the data or returns NoRecordFoundException if not found
        /// </summary>
        /// <param name="name">Name of Contact to be deleted</param>
        /// <param name="contactList">List of contacts from which data is to be deleted</param>
        public static void RecordDelete(string name, List<Contact> contactList)
        {
            bool IsPresent = false;
            foreach (var c in contactList)
            {
                if (c.getName() == name)
                {
                    IsPresent = true;
                }
            }
            if (IsPresent == false)
            {
                throw new NoRecordFoundException(Constants.NoRecordFound);
            }
            else
            {
                contactList.RemoveAll(x => x.getName() == name);
            }
        }
    }
}
