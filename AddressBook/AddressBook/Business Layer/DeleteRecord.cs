using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class DeleteRecord
    {
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
