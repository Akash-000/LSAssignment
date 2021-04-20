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

            //Invoking method for further processing of queries
            type.InvokeMember("MoreQueries", BindingFlags.InvokeMethod, null, c, new object[] { });
            Console.Read();
        }
    }
}
