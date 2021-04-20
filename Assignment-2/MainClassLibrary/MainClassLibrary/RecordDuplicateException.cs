using System;
using System.Runtime.Serialization;

namespace MainClassLibrary
{
    [Serializable]
    internal class RecordDuplicateException : Exception
    {
        public RecordDuplicateException(string message)
        {
            Console.WriteLine(message+" Already Exists");
        }
    }
}