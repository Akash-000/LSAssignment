using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainClassLibrary;
namespace EmployeeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterClass Employee = new MasterClass();
            ///Invoking ReadingCsvFile Method to Read data from file
            Employee.ReadingCsvFile();
            
            while(true)
            {
                Console.WriteLine(Constants.SwitchStatements);

                int ChoosenValue = 0;
                try
                {
                    ChoosenValue = int.Parse(Console.ReadLine());
                }
                catch(FormatException exp)
                {
                    Console.WriteLine(Constants.newline+exp.Message+Constants.newline);
                }
                
                if (ChoosenValue == 4)
                    break;
                //Invoking method for further processing of queries
                Employee.MoreQueries(ChoosenValue);
            }
            Console.Read();
        }
    }
}
