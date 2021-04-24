using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Search
    {
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
