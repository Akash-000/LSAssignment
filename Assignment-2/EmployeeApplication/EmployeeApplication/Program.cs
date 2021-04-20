using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace EmployeeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //loading the assembly in the program using reflection

            Assembly assembly = Assembly.LoadFile("C:\\C# programs\\day7\\Assignment-2\\MainClassLibrary\\MainClassLibrary\\bin\\Debug\\MainClassLibrary.dll");
            Type type = assembly.GetType("MainClassLibrary.ReadFile");
            var c = Activator.CreateInstance(type);

            //Invoking ReadingCsvFile method in ReadFile Class of the Assembly
            type.InvokeMember("ReadingCsvFile", BindingFlags.InvokeMethod, null, c, new object[] { });
            Console.WriteLine("Press Any Key...");
            Console.Read();


            while(true)
            {
                Console.WriteLine("\n\nPlease Select Below Provided Options As Per The Requirement:-\n1. Search For Manager Of An Employee");
                Console.WriteLine("2. Search For Employee Reporting To A Manager\n3. Quit");
                int ChoosenValue = 0;
                try
                {
                    ChoosenValue = int.Parse(Console.ReadLine());
                }
                catch(FormatException exp)
                {
                    Console.WriteLine("\n\n"+exp+"\n\n");
                }
                

                if (ChoosenValue == 3)
                    break;

                //Invoking method for further processing of queries

                type.InvokeMember("MoreQueries", BindingFlags.InvokeMethod, null, c, new object[] { ChoosenValue});

            }
            Console.Read();
        }
    }
}
