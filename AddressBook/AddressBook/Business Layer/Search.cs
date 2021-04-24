using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Search
    {
        /// <summary>
        /// Search and Prints data searched
        /// prints all the records if value searched is Empty
        /// </summary>
        /// <param name="value">value to be searched</param>
        /// <param name="contactList">List from which value is to be searched</param>
        /// <param name="director">Specifies if searched Item is Name of Person or Name of Organisation</param>
        public static void SearchData(string value, List<Contact> contactList, string director)
        {
            if(value==string.Empty)
            {
                foreach (var c in contactList)
                {
                    Console.WriteLine(Constants.NameHeading + c.getName() + Constants.OrganisationHeading + c.getOrganisation());
                    Console.WriteLine(Constants.PhoneHeading);
                    foreach (var d in c.getPhoneNumbers())
                    {
                        Console.WriteLine($"{d.getLabel()} :    {d.getPhoneNumber()}");
                    }
                    Console.WriteLine(Constants.AddressHeading);
                    foreach (var d in c.getAddresses())
                    {
                        Console.WriteLine($"{d.getLabel()} :    {d.getAddress()}");
                    }
                }
            }
            else
            {
                bool IsPresent = false;
                foreach (var c in contactList)
                {
                    string Controller = "";
                    if(director == Constants.Name)
                    {
                        Controller = c.getName();
                    }
                    else
                    {
                        Controller = c.getOrganisation();
                    }
                    if (Controller.ToUpper().Contains(value.ToUpper()))
                    {
                        IsPresent = true;
                        Console.WriteLine(Constants.NameHeading + c.getName() + Constants.OrganisationHeading + c.getOrganisation());
                        Console.WriteLine(Constants.PhoneHeading);
                        foreach (var d in c.getPhoneNumbers())
                        {
                            Console.WriteLine($"{d.getLabel()} :    {d.getPhoneNumber()}");
                        }
                        Console.WriteLine(Constants.AddressHeading);
                        foreach (var d in c.getAddresses())
                        {
                            Console.WriteLine($"{d.getLabel()} :    {d.getAddress()}");
                        }
                    }
                }
                if (IsPresent == false)
                {
                    throw new NoRecordFoundException(Constants.NoRecordFound);
                }
            }
        }
    }
}
