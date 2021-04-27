using System;
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
            string Name;
            string OrganisationName;
            GetContactDetails:  try
            {
                Name = ContactDetails.TakeName();
                OrganisationName = ContactDetails.TakeOrganisationName();
            }
            catch(InvalidSyntaxException exp)
            {
                Console.WriteLine(exp.Message);
                goto GetContactDetails;
            }
            Contact NewContact = new Contact(Name, OrganisationName);
            int NumberOfInputs = 1;
            PhoneNumberDetails: try
            {
                Console.WriteLine(Constants.NumberOfContact);
                NumberOfInputs = int.Parse(Console.ReadLine());
                while (NumberOfInputs > 0)
                {
                    PhoneNumber NewPhoneData = SetFields.SetPhoneNumber();
                    NewContact.addPhoneNumbers(NewPhoneData);
                    NumberOfInputs--;
                }
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message+"\n");
                goto PhoneNumberDetails;
            }
            AddressDetails: try
            {
                Console.WriteLine(Constants.NumberOfAddress);
                NumberOfInputs = int.Parse(Console.ReadLine());
                while (NumberOfInputs > 0)
                {
                    Address NewAddressData = SetFields.SetAddress();
                    NewContact.addAddresses(NewAddressData);
                    NumberOfInputs--;
                }
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message+"\n");
                goto AddressDetails;
            }
            return NewContact;
        }
    }
}
