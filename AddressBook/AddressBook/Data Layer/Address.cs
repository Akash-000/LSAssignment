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
