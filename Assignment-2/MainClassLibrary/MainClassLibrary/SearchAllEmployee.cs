using System.Collections.Generic;
using System.Linq;
namespace MainClassLibrary
{
    internal class SearchAllEmployee
    {/// <summary>
    /// Search All Employees Reporting Directly or indirectly to a manager
    /// </summary>
    /// <param name="Details"></param>
    /// <param name="ManID"></param>
        public static void AllEmployeeNames(List<Employee> Details, int ManID)
        {
            List<string> Test = new List<string>();
            var employeesworking = Details.Where(emp => emp.ManagerID == ManID)
                                    .Select(emp => new
                                    {
                                        EmployeeID = emp.EmpID,
                                        EmpName = emp.EmpName,
                                        EmpEmail = emp.EmpEmail
                                    }).ToList();

            foreach(var emp in employeesworking)
            {
                Test.Add(emp.EmpName);
            }
            foreach(var emp in Test)
            {
                System.Console.WriteLine($"{emp}");
            }
        }
    }
}