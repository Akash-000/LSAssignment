using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Constants
    {
        public const string Heading = "\t\t\t\t\t\tADDRESS BOOK APPLICATION";
        public const string SwitchStatements = "\nPLEASE SELECT ONE OF THE OPTION BELOW:-\n1. ADD RECORD\n2. SEARCH BY NAME\n"+
                                                    "3. SEARCH BY ORGANISATION NAME\n4. UPDATE CONTACT\n5. DELETE CONTACT\n6. EXIT";
        public const string OptedAddRecord = "You Selected To Add Record";
        public const string SearchByNameOpted = "You Opted For Search Contact By Name";
        public const string SearchByOrganisation = "Opted For Search Contact By Organisation Name";
        public const string UpdateContactOpted = "You Opted For Update Contact";
        public const string DeleteContactOpted = "You Opted For Delete Contact";
        public const string DefaultStatement = "Please Select A Valid Option";
        public const string DuplicateExceptionMessage = "Record Already Present !!!";
        public const string RegEXExpression = "^(?=.*[a-zA-Z])(?=.*[0-9])[A-Za-z0-9]+$";
        public const string SyntaxExceptionMessageName = "Given Name Is Invalid, The Input Cannot be EMPTY Or Greater Than 255 Characters";
        public const string SyntaxExceptionMessage = "Given Label Is Invalid, The Input Cannot be EMPTY Or Greater Than 255 Characters";
        public const string AskName = "Enter Name :";
        public const string AskOrganisationName = "Enter Organisation Name :";
        public const string OrganisationNotGiven = "Not Given";
        public const string AskPhoneNumberLabel = "Enter Phone Number Label";
        public const string AskPhoneNumber = "Enter PhoneNumber";
        public const string AskAddressLabel = "Enter Address Label : ";
        public const string AskAddress = "Enter Address : ";
        public const string NoRecordFound = "No Record Found !!!";
        public const string NameHeading = "\nName : ";
        public const string OrganisationHeading = "\nOrganisation : ";
        public const string PhoneHeading = "Phone :- ";
        public const string AddressHeading = "Address :- ";
        public const string AskNameDelete = "Please Provide Name of Contact To Be Deleted";
        public const string AskOrganisationSearch = "Please Provide Name of Organisation To Be Searched";
        public const string AskNameSearch = "Please Provide Name of Contact To Be Searched";
        public const string ContactDeleteConfirmation = "Contact Deleted Successfully !!!";
        public const string UpdateContactName = "Please Provide Name To Update Corresponding Record : ";
        public const string NumberOfAddress = "Enter Number of Address";
        public const string NumberOfContact = "Enter Number of Contacts : ";
        public const string OrganisationException = "Organisation Name Cannot Be Greater Than 255 Words !!!";
        public const string InvalidNumberException = "Phone Number Should be Of 10 Digits And Should Contain Only Digits !!!";
        public const string NotGiven = "Not Given";
        public const string UpdateConfirm = "Contact Updated Successfully !!!";
        public const string ListEmpty = "No Records Present To Perform The Operation";
        public const string Name = "Name";
    }
}
