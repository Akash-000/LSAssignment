using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MainClassLibrary
{
    public class ReadFile
    {
        List<Employee> EmpDetails = new List<Employee>();
        public void ReadingCsvFile()
        {
            //Declaring a HashSet for checking the repetition in the DataBase
            HashSet<int> repetition = new HashSet<int>();

            string[] details = File.ReadAllLines(@"C:\C# programs\day7\Assignment-2\Record\EmployeeDetails.csv");
            
            foreach(var record in details)
            {
                string[] fields = record.Split(',');
                Employee emp = new Employee()           //Creating an employee entity using the data in DataBase
                {
                    EmpID = int.Parse(fields[0]),
                    EmpName = fields[1],
                    ManagerID = int.Parse(fields[2]),
                    EmpEmail = fields[3]
                };
                try                                     //Checking for duplicate records
                {
                    if (repetition.Contains(int.Parse(fields[0])))
                        throw new RecordDuplicateException(record);
                    else
                    {
                        repetition.Add(int.Parse(fields[0]));
                        EmpDetails.Add(emp);
                    }
                }
                catch(RecordDuplicateException exp)
                {
                    Console.WriteLine(exp);
                }    
            }
           
            SortEmployee.PrintSortedCollection(EmpDetails);         //Sorting the Employee Collection
            Console.WriteLine("\nThe Record Of The Employees Is Displayed Above\n\n");
        }

        public void MoreQueries()                               //Method for Further processing
        {
            Console.WriteLine("Please Select Below Provided Options As Per The Requirement:-\n1. Search For Manager Of An Employee");
            Console.WriteLine("2. Search For Employee Reporting To A Manager");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    {
                        Console.Write("Please Provide Employee ID :\t");
                        int EmpID = int.Parse(Console.ReadLine());

                        SearchManagerName.GetManagerName(EmpID, EmpDetails);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Please Provide Manager ID:");
                        int ManID = int.Parse(Console.ReadLine());

                        SearchAllEmployee.AllEmployeeNames(EmpDetails,ManID);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please Select A Valid Option !!!");
                        break;
                    }
            }
        }
    }
}
