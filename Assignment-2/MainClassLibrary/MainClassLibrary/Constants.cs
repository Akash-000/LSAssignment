using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary
{/// <summary>
/// Class containing All Strings Used in the project
/// </summary>
    public class Constants
    {
        public const string SwitchStatements= "\n\nPlease Select Below Provided Options As Per The Requirement:-\n1. Search For Manager Of An Employee\n2. Search For Employee Reporting To A Manager\n3. Display Records\n4. Quit";
        public const string newline = "\n\n";
        public const string GetEmployeeID = "Please Provide Employee ID :\t";
        public const string GetManagerID = "Please Provide Manager ID:";
        public const string SortedHeading = "Sorted Records :- \n";
        public const string DefaultString = "Please Select A Valid Option !!!";
        public const string DuplicateExceptionMessage = " Already Exists And Hence Is Not Loaded";
        public const string TopManager = "The Given Employee Is The Top Manager";
        public const string ManagerDeclaration = "The Manager is : ";
        public const string FilePath = "..\\..\\..\\..\\Record\\EmployeeDetails.csv";
    }
}
