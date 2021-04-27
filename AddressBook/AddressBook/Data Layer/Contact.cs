using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        private string _name;
        private string _organisation;
        private List<PhoneNumber> _phoneNumbers = new List<PhoneNumber>();
        private List<Address> _addresses = new List<Address>();

        /// <summary>
        /// Constructor to initialise private fields
        /// </summary>
        /// <param name="name">Intitialises _name field</param>
        /// <param name="organisation">Initialises _organisation field</param>
        public Contact(string name, string organisation)
        {
            this._name = name;
            this._organisation = organisation;
        }
        /// <summary>
        /// return name of record
        /// </summary>
        /// <returns>name of record</returns>
        public string getName()
        {
            return _name;
        }
        /// <summary>
        /// return organisation name
        /// </summary>
        /// <returns>organisation name of record</returns>
        public string getOrganisation()
        {
            return _organisation;
        }
        /// <summary>
        /// return list of phone numbers of the record
        /// </summary>
        /// <returns>List of phone numbers</returns>
        public List<PhoneNumber> getPhoneNumbers()
        {
            return _phoneNumbers;
        }
        /// <summary>
        /// Returns list of addresses of the record
        /// </summary>
        /// <returns>List of addresses</returns>
        public List<Address> getAddresses()
        {
            return _addresses;
        }
        /// <summary>
        /// adds A PhoneNumber type object to _phonenumber list
        /// </summary>
        /// <param name="phoneObject">Object Containing field - label and phone number</param>
        public void addPhoneNumbers(PhoneNumber phoneObject)
        {
            _phoneNumbers.Add(phoneObject);
        }
        /// <summary>
        /// adds an Address type object to _addresses list
        /// </summary>
        /// <param name="addressObject">Object containing field - label and address</param>
        public void addAddresses(Address addressObject)
        {
            _addresses.Add(addressObject);
        }
    }
}
