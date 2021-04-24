using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Address
    {
        private string _label;
        private string _addressDetail;
        /// <summary>
        /// Constructor to initialise _label and _addressDetails
        /// </summary>
        /// <param name="label">initialises _label field</param>
        /// <param name="address">initialises _addressDetail field</param>
        public Address(string label, string address)
        {
            this._label = label;
            this._addressDetail = address;
        }
        public string getLabel()
        {
            return _label;
        }
        public string getAddress()
        {
            return _addressDetail;
        }
    }
}
