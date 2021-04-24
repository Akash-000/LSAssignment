using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AddressBook
{
    internal class AddRecord
    {
        /// <summary>
        /// Creates A Contact Object And Initialises All Its Fields
        /// </summary>
        /// <returns>Returns A Contact Object To Menu</returns>
        public static Contact AddDetails()
        {
            x:  Console.WriteLine(Constants.AskName);
            string Name = Console.ReadLine();
            Console.WriteLine(Constants.AskOrganisationName);
            string OrganisationName = Console.ReadLine();
            try
            {
                long i;
                if (Name.Length <= 0 || Name.Length > 255 || Regex.IsMatch(Name, Constants.RegEXExpression) || long.TryParse(Name, out i))
                    throw new InvalidSyntaxException(Constants.SyntaxExceptionMessageName);
                if (OrganisationName.Length > 255)
                    throw new InvalidSyntaxException(Constants.OrganisationException);
            }
            catch(InvalidSyntaxException exp)
            {
                Console.WriteLine(exp.Message);
                goto x;
            }
            if (OrganisationName == string.Empty)
            {
                OrganisationName = Constants.NotGiven;
            }
            Contact NewContact = new Contact(Name, OrganisationName);
            int N = 1;
            y: try
            {
                Console.WriteLine(Constants.NumberOfContact);
                N = int.Parse(Console.ReadLine());
                while (N > 0)
                {
                    PhoneNumber NewPhoneData = SetFields.SetPhoneNumber();
                    NewContact.addPhoneNumbers(NewPhoneData);
                    N--;
                }
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message+"\n");
                goto y;
            }
            z: try
            {
                Console.WriteLine(Constants.NumberOfAddress);
                N = int.Parse(Console.ReadLine());
                while (N > 0)
                {
                    Address NewAddressData = SetFields.SetAddress();
                    NewContact.addAddresses(NewAddressData);
                    N--;
                }
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message+"\n");
                goto z;
            }
            return NewContact;
        }
    }
}
