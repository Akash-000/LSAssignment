using System;
using System.Collections.Generic;
using System.Linq;
namespace MainClassLibrary
{
    internal class SearchManagerName
    {
        /// <summary>
        /// Returns manager Name of an employee
        /// </summary>
        /// <param name="EmpID"></param>
        /// <param name="Details"></param>
        public static void GetManagerName(int EmpID, List<Employee> Details)
        {
            var ManID = Details.Find(x => x.EmpID == EmpID);
            if(ManID.ManagerID==-1)
            {
                Console.WriteLine(Constants.TopManager);
            }
            else
            {
                var EmpName = Details.Find(x => x.EmpID == ManID.ManagerID);
                Console.WriteLine(EmpName.EmpName);
            }
            
        }
    }
}