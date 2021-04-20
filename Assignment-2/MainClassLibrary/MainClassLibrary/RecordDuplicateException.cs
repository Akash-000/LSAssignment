using System;
using System.Runtime.Serialization;

namespace MainClassLibrary
{
    [Serializable]
    internal class RecordDuplicateException : Exception
    {
        public RecordDuplicateException(string Message)
        {
            Console.WriteLine(Message+ Constants.DuplicateExceptionMessage);
        }
    }
}