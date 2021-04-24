using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace AddressBook
{
    internal class SetFields
    {
        /// <summary>
        /// Sets private fields of PhoneNumber Class
        /// </summary>
        /// <returns>PhoneNumber class object</returns>
        public static PhoneNumber SetPhoneNumber()
        {
            Console.WriteLine(Constants.AskPhoneNumberLabel);
            string Label = Console.ReadLine();
            long i;
            if (Label.Length <= 0 || Label.Length > 255 || Regex.IsMatch(Label, Constants.RegEXExpression) || long.TryParse(Label, out i))
                throw new InvalidSyntaxException(Constants.SyntaxExceptionMessage);
            Console.WriteLine(Constants.AskPhoneNumber);
            string Number = Console.ReadLine();
            int j;
            if (Number.Length != 10 || int.TryParse(Number, out j))
                throw new InvalidPhoneNumber(Constants.InvalidNumberException);
            PhoneNumber Details = new PhoneNumber(Label, Number);
            return Details;
        }
        /// <summary>
        /// Sets private fields of Address Class
        /// </summary>
        /// <returns>Address Class Object</returns>
        public static Address SetAddress()
        {
            Console.WriteLine(Constants.AskAddressLabel);
            string Label = Console.ReadLine();
            long i;
            if (Label.Length <= 0 || Label.Length > 255 || Regex.IsMatch(Label, Constants.RegEXExpression) || long.TryParse(Label, out i))
                throw new InvalidSyntaxException(Constants.SyntaxExceptionMessage);
            Console.WriteLine(Constants.AskAddress);
            string Address = Console.ReadLine();
            if(Address == string.Empty)
            {
                Address = Constants.NotGiven;
            }
            Address Details = new Address(Label, Address);
            return Details;
        }
    }
}
