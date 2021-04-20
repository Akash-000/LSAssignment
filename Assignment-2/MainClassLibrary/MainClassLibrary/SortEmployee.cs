using System.Collections.Generic;
using System.Linq;


namespace MainClassLibrary
{
    internal class SortEmployee
    {
        /// <summary>
        /// Sorts the passes Employee Collection argument using LINQ
        /// </summary>
        /// <param name="EmployeeList"></param>
        public static void PrintSortedCollection(List<Employee> EmployeeList)
        {
            List<Employee> SortedList = EmployeeList.OrderBy(x => x.EmpName)
                                        .ThenBy(x => x.EmpID)
                                        .ToList();

            SortedList.ForEach(x => System.Console.WriteLine($"{x.EmpID},   {x.EmpName},  {x.ManagerID},  {x.EmpEmail}"));
            
        }
    }
}