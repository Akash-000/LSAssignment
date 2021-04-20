using System.Collections.Generic;
using System.Linq;


namespace MainClassLibrary
{
    internal class SortEmployee
    {
        public static void PrintSortedCollection(List<Employee> list)
        {
            //using Linq query to sort the Employee collection
            List<Employee> sortedList = list.OrderBy(x => x.EmpName)
                                        .ThenBy(x => x.EmpID)
                                        .ToList();

            //Writing the sorted collection
            sortedList.ForEach(x => System.Console.WriteLine($"{x.EmpID},   {x.EmpName},  {x.ManagerID},  {x.EmpEmail}"));
            
        }
    }
}