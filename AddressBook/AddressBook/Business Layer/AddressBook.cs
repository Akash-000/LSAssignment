using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        /// <summary>
        /// Stores and Maintain a List Of Contacts Provided By User
        /// </summary>
        private List<Contact> _listContact = new List<Contact>();
        /// <summary>
        /// Adds Contact To List
        /// </summary>
        /// <param name="contactObject">Contains All The Details Of One Record</param>
        public void addContact(Contact contactObject)
        {
            _listContact.Add(contactObject);
        }
        /// <summary>
        /// Makes A Call to Static Method SearchData
        /// or return if _listContact is empty
        /// </summary>
        /// <param name="name">Name of Person whose record to find</param>
        public void SearchByName(string name)
        {
            if(_listContact.Count==0)
            {
                Console.WriteLine(Constants.ListEmpty);
                return;
            }
            Search.SearchData(name, _listContact, "Name");
        }
        /// <summary>
        /// Makes a Call to static method of searchdata
        /// or return if _listContact is empty
        /// </summary>
        /// <param name="organisationName">Organisation Name of Person whose record to find</param>
        public void SearchByOrganisation(string organisationName)
        {
            if (_listContact.Count == 0)
            {
                Console.WriteLine(Constants.ListEmpty);
                return;
            }
            Search.SearchData(organisationName, _listContact, "Organisation");
        }
        /// <summary>
        /// Updates Record of the list by using DeleteContact and addContact methods simultaneously
        /// </summary>
        /// <param name="name">Name whose record is to be updated</param>
        /// <param name="contactObject">Contain all details of the updated record</param>
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
        /// <summary>
        /// Makes a call to static method RecordDelete
        /// </summary>
        /// <param name="name">Name of record to be deleted</param>
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
