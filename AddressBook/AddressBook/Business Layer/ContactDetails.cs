using System;
using System.Text.RegularExpressions;
namespace AddressBook
{
    public class ContactDetails
    {
        /// <summary>
        /// Takes Name of Record from user
        /// </summary>
        /// <returns>Return the Name provided by the user after checking its validation</returns>
        public static string TakeName()
        {
            string Name;
            Console.WriteLine(Constants.AskName);
            Name = Console.ReadLine();
            long i;
            if (Name.Length <= 0 || Name.Length > 255 || Regex.IsMatch(Name, Constants.RegEXExpression) || long.TryParse(Name, out i))
                throw new InvalidSyntaxException(Constants.SyntaxExceptionMessageName);
            return Name;
        }
        /// <summary>
        /// Takes Organisation Name of Record from user
        /// </summary>
        /// <returns>Return the organisation Name provided by the user after checking its validation</returns>
        public static string TakeOrganisationName()
        {
            string OrganisationName;
            Console.WriteLine(Constants.AskOrganisationName);
            OrganisationName = Console.ReadLine();
            if (OrganisationName == string.Empty)
            {
                OrganisationName = Constants.NotGiven;
            }
            if (OrganisationName.Length > 255)
                throw new InvalidSyntaxException(Constants.OrganisationException);
            return OrganisationName;
        }
    }
}
