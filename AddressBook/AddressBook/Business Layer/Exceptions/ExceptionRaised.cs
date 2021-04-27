using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class DuplicateRecordException : Exception
    {
        public DuplicateRecordException(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class InvalidSyntaxException : Exception
    {
        public InvalidSyntaxException(string Message)
        {
            Console.WriteLine(Message);
        }
    }
    public class NoRecordFoundException : Exception
    {
        public NoRecordFoundException(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class InvalidPhoneNumber : Exception
    {
        public InvalidPhoneNumber(string message)
        {
            Console.WriteLine(message);
        }
    }
}
