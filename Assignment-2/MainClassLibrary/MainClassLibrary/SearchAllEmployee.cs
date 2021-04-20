using System.Collections.Generic;
using System.Linq;
namespace MainClassLibrary
{
    internal class SearchAllEmployee
    {
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
                System.Console.WriteLine($"{emp}");
        }
    }
}