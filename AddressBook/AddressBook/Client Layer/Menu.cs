using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Menu
    {
        /// <summary>
        /// Provides User With Options To Use AddressBook
        /// And Handles Each Option
        /// </summary>
        internal static void Options()
        {
            HashSet<string> ForRepetition = new HashSet<string>();
            AddressBook AllRecords = new AddressBook();
            x:  try
            {
                while (true)
                {
                    Console.WriteLine(Constants.SwitchStatements);
                    int OptionSelected = int.Parse(Console.ReadLine());
                    if (OptionSelected == 6)
                    {
                        break;
                    }
                    switch (OptionSelected)
                    {
                        case 1:
                            {
                                Console.WriteLine(Constants.OptedAddRecord);
                                Contact NewContact = AddRecord.AddDetails();
                                if (ForRepetition.Contains(NewContact.getName()))
                                    throw new DuplicateRecordException(Constants.DuplicateExceptionMessage);
                                else
                                {
                                    ForRepetition.Add(NewContact.getName());
                                }
                                AllRecords.addContact(NewContact);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine(Constants.SearchByNameOpted);
                                Console.WriteLine(Constants.AskNameSearch);
                                string Name = Console.ReadLine();
                                AllRecords.SearchByName(Name);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine(Constants.SearchByOrganisation);
                                Console.WriteLine(Constants.AskOrganisationSearch);
                                string OrganisationName = Console.ReadLine();
                                AllRecords.SearchByOrganisation(OrganisationName);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine(Constants.UpdateContactOpted);
                                Console.WriteLine(Constants.UpdateContactName);
                                string Name = Console.ReadLine();
                                if (!ForRepetition.Contains(Name))
                                {
                                    throw new NoRecordFoundException(Constants.NoRecordFound);
                                }
                                Contact UpdateContact = AddRecord.AddDetails();
                                if (Name != UpdateContact.getName() && !ForRepetition.Contains(UpdateContact.getName()))
                                {
                                    ForRepetition.Remove(Name);
                                    ForRepetition.Add(UpdateContact.getName());
                                }
                                AllRecords.UpdateContact(Name, UpdateContact);
                                Console.WriteLine(Constants.UpdateConfirm);
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine(Constants.DeleteContactOpted);
                                Console.WriteLine(Constants.AskNameDelete);
                                string Name = Console.ReadLine();
                                AllRecords.DeleteContact(Name);
                                Console.WriteLine(Constants.ContactDeleteConfirmation);
                                ForRepetition.Remove(Name);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine(Constants.DefaultStatement);
                                break;
                            }
                    }
                }
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message+"\n");
                goto x;
            }
        }
    }
}
