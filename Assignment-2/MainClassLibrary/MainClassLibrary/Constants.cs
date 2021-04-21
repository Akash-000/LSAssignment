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
        public static string SwitchStatements= "\n\nPlease Select Below Provided Options As Per The Requirement:-\n1. Search For Manager Of An Employee\n2. Search For Employee Reporting To A Manager\n3. Display Records\n4. Quit";
        public static string newline = "\n\n";
        public static string GetEmployeeID = "Please Provide Employee ID :\t";
        public static string GetManagerID = "Please Provide Manager ID:";
        public static string SortedHeading = "Sorted Records :- \n";
        public static string DefaultString = "Please Select A Valid Option !!!";
        public static string DuplicateExceptionMessage = " Already Exists And Hence Is Not Loaded";
        public static string TopManager = "The Given Employee Is The Top Manager";
        public static string ManagerDeclaration = "The Manager is : ";
        public static string FilePath = "..\\..\\..\\..\\Record\\EmployeeDetails.csv";
    }
}
