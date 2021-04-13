using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagePrinter_library
{
    public class RefClass : Exception
    {
        public string printer(string message)           //method to print the message
        {
            if (message == "")                   //Check for empty message
                throw new ArgumentException("Enter valid string"); 
            else
            {
                return "Hello " + message;
            }
        }
    }
}
