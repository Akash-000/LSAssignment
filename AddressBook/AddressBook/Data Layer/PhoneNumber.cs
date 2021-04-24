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
        /// <summary>
        /// Constructor To Initialise Private Field
        /// </summary>
        /// <param name="label">Initialises _label Field</param>
        /// <param name="number">Initialises _phoneNumber Field</param>
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
