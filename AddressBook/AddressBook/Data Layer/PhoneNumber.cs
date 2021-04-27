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
        /// <summary>
        /// return label of phonenumber
        /// </summary>
        /// <returns>Label of phone number</returns>
        public string getLabel()
        {
            return _label;
        }
        /// <summary>
        /// return the phone number
        /// </summary>
        /// <returns>phone number of the record</returns>
        public string getPhoneNumber()
        {
            return _phoneNumber;
        }
    }
}
