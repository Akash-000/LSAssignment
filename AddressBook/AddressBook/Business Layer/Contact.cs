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

        public Contact(string name, string organisation)
        {
            this._name = name;
            this._organisation = organisation;
        }
        public string getName()
        {
            return _name;
        }
        public string getOrganisation()
        {
            return _organisation;
        }
        public List<PhoneNumber> getPhoneNumbers()
        {
            return _phoneNumbers;
        }
        public List<Address> getAddresses()
        {
            return _addresses;
        }
        public void addPhoneNumbers(PhoneNumber phoneObject)
        {
            _phoneNumbers.Add(phoneObject);
        }
        public void addAddresses(Address addressObject)
        {
            _addresses.Add(addressObject);
        }
    }
}
