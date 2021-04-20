using System.Collections.Generic;
using System.Linq;


namespace MainClassLibrary
{
    internal class SortEmployee
    {
        /// <summary>
        /// Sorts the passes Employee Collection argument using LINQ
        /// </summary>
        /// <param name="list"></param>
        public static void PrintSortedCollection(List<Employee> list)
        {
            List<Employee> sortedList = list.OrderBy(x => x.EmpName)
                                        .ThenBy(x => x.EmpID)
                                        .ToList();

            sortedList.ForEach(x => System.Console.WriteLine($"{x.EmpID},   {x.EmpName},  {x.ManagerID},  {x.EmpEmail}"));
            
        }
    }
}