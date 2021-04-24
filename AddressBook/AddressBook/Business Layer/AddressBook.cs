using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        private List<Contact> _listContact = new List<Contact>();
        public void addContact(Contact contactObject)
        {
            _listContact.Add(contactObject);
        }
        public void SearchByName(string name)
        {
            if(_listContact.Count==0)
            {
                Console.WriteLine(Constants.ListEmpty);
                return;
            }
            Search.SearchData(name, _listContact, "Name");
        }
        public void SearchByOrganisation(string organisationName)
        {
            if (_listContact.Count == 0)
            {
                Console.WriteLine(Constants.ListEmpty);
                return;
            }
            Search.SearchData(organisationName, _listContact, "Organisation");
        }
        public void UpdateContact(string name, Contact contactObject)
        {
            if (_listContact.Count == 0)
            {
                Console.WriteLine(Constants.ListEmpty);
                return;
            }
            foreach (var c in _listContact)
            {
                if (c.getName() == contactObject.getName() && name != contactObject.getName())
                {
                    throw new DuplicateRecordException(Constants.DuplicateExceptionMessage);
                }
            }
            DeleteContact(name);
            addContact(contactObject);
        }
        public void DeleteContact(string name)
        {
            if (_listContact.Count == 0)
            {
                Console.WriteLine(Constants.ListEmpty);
                return;
            }
            DeleteRecord.RecordDelete(name, _listContact);
        }
    }
}
