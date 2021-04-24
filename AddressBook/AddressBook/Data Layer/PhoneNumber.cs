using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class PhoneNumber
    {
        private string _label;
        private string _phoneNumber;

        public PhoneNumber(string label, string number)
        {
            this._label = label;
            this._phoneNumber = number;
        }
        public string getLabel()
        {
            return _label;
        }
        public string getPhoneNumber()
        {
            return _phoneNumber;
        }
    }
}
