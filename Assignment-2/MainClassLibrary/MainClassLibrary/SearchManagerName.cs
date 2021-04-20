using System;
using System.Collections.Generic;
using System.Linq;
namespace MainClassLibrary
{
    internal class SearchManagerName
    {
        public static void GetManagerName(int EmpID, List<Employee> details)
        {
            int ManID = 0 ;
            //Getting Employee ID of the Manager
            foreach(var record in details)
            {
                if(record.EmpID == EmpID)
                {
                    ManID = record.ManagerID;
                    break;
                }
            }
            //Getting Employee Name from the obtained Employee ID
            foreach(var record in details)
            {
                if(ManID == -1)
                {
                    Console.WriteLine("The Given Employee Is The Top Manager");
                    break;
                }
                if(ManID == record.EmpID)
                {
                    Console.WriteLine("The Manager is : "+record.EmpName);
                }
            }
            
                        

        }
    }
}