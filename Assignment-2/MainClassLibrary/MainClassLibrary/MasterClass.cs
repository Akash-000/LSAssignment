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
        private List<Employee> _empDetails = new List<Employee>();

        /// <summary>
        /// Reads Data from CSV File, Raise an exception when duplicate records are found and Sorts the 
        /// read data
        /// </summary>
        public void ReadingCsvFile()
        {
            //Declaring a HashSet for checking the Repetition in the DataBase
            HashSet<int> Repetition = new HashSet<int>();
            try
            {
                string[] Details = File.ReadAllLines(Constants.FilePath);
                foreach (var Record in Details)
                {
                    string[] Fields = Record.Split(',');
                    //Condition to remove null anomalies
                    if (Fields[2] == "null")
                        Fields[2] = "-1";
                    //Creating an employee entity using the data in DataBase
                    Employee emp = new Employee()           
                    {
                        EmpID = int.Parse(Fields[0]),
                        EmpName = Fields[1],
                        ManagerID = int.Parse(Fields[2]),
                        EmpEmail = Fields[3]
                    };

                    if (Repetition.Contains(int.Parse(Fields[0])))
                    {
                        throw new RecordDuplicateException(Record);
                    }
                    else
                    {
                        Repetition.Add(int.Parse(Fields[0]));
                        _empDetails.Add(emp);
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

                            SearchManagerName.GetManagerName(EmpID, _empDetails);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(Constants.GetManagerID);
                            int ManID = int.Parse(Console.ReadLine());

                            SearchAllEmployee.AllEmployeeNames(_empDetails, ManID);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(Constants.SortedHeading);
                            SortEmployee.PrintSortedCollection(_empDetails);
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
