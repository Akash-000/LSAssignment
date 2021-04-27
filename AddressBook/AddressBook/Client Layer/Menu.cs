using System;
using System.Collections.Generic;

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
                                Utility.RepetitionCheck(ForRepetition, NewContact.getName());
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
                                Contact UpdateContact = AddRecord.AddDetails();
                                Utility.CheckUpdateFeasibility(ForRepetition, Name, UpdateContact.getName());
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
