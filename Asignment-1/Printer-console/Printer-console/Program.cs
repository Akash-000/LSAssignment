using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Printer_console
{
    class Program
    { 
        static void Main(string[] args)
        {
            /*
             * Load assembly at runtime
             */
            Assembly assembly = Assembly.LoadFile("C:\\Users\\akash.chauhan\\Documents\\Visual Studio 2015\\Projects\\Printer-console\\Printer-console\\bin\\Debug\\MessagePrinter-library.dll");
            
            /*
             * Creating a reference of type Type
             */
            Type type = assembly.GetType("MessagePrinter_library.RefClass");
          
            
            /*
             * create instance of RefClass
             */
            var c = Activator.CreateInstance(type);

            try
            {
                string message = Console.ReadLine();

                /*
                 * Invoke the printer method
                 */
                Console.WriteLine(type.InvokeMember("printer", BindingFlags.InvokeMethod, null, c, new object[] { message }));

            }
            catch(ArgumentException exp)
            {
                Console.WriteLine(exp.ToString());
            }
            catch(TargetInvocationException exp)
            {
                Console.WriteLine(exp.ToString());
            }


            Console.Read();
        }
    }
}
