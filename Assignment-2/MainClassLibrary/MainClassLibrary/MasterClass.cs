using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MainClassLibrary
{
    public class MasterClass
    {
        /// <summary>
        /// Collection of type Employees for further query processing
        /// </summary>
        List<Employee> EmpDetails = new List<Employee>();

        /// <summary>
        /// Reads Data from CSV File, Raise an exception when duplicate records are found and Sorts the 
        /// read data
        /// </summary>
        public void ReadingCsvFile()
        {
            //Declaring a HashSet for checking the repetition in the DataBase
            HashSet<int> repetition = new HashSet<int>();
            try
            {

                string[] details = File.ReadAllLines(@"C:\C# programs\day7\Assignment-2\Record\EmployeeDetails.csv");

                foreach (var record in details)
                {
                    string[] fields = record.Split(',');
                    //Condition to remove null anomalies
                    if (fields[2] == "null")
                        fields[2] = "-1";
                    //Creating an employee entity using the data in DataBase
                    Employee emp = new Employee()           
                    {
                        EmpID = int.Parse(fields[0]),
                        EmpName = fields[1],
                        ManagerID = int.Parse(fields[2]),
                        EmpEmail = fields[3]
                    };

                    if (repetition.Contains(int.Parse(fields[0])))
                    {
                        throw new RecordDuplicateException(record);
                    }
                    else
                    {
                        repetition.Add(int.Parse(fields[0]));
                        EmpDetails.Add(emp);
                    }
                    
                }
            }
            catch (RecordDuplicateException exp)
            {
                Console.WriteLine(exp.Message);
            }
            catch(FileNotFoundException exp)
            {
                Console.WriteLine(exp.Message);
            }


        }
        /// <summary>
        /// Provides functionality like Getting manager name from employee id,
        /// Get details of employees working under a manager
        /// Sorting the employee collection 
        /// </summary>
        /// <param name="ChoosenValue"></param>
        public void MoreQueries(int ChoosenValue)                               
        {
            try
            {
                switch (ChoosenValue)
                {
                    case 1:
                        {
                            Console.Write(Constants.GetEmployeeID);
                            int EmpID = int.Parse(Console.ReadLine());

                            SearchManagerName.GetManagerName(EmpID, EmpDetails);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(Constants.GetManagerID);
                            int ManID = int.Parse(Console.ReadLine());

                            SearchAllEmployee.AllEmployeeNames(EmpDetails, ManID);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(Constants.SortedHeading);
                            SortEmployee.PrintSortedCollection(EmpDetails);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine(Constants.DefaultString);
                            break;
                        }
                }
            }
            catch(FormatException exp)
            {
                Console.WriteLine(Constants.newline + exp.Message + Constants.newline);
            }
            
        }
    }
}
