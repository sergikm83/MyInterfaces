using System;
using System.Collections;

namespace IssuesWithNongenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void SimpleBoxUnboxOperation()
        {
            int myInt = 25;
            object boxedInt = myInt;
            int unboxedInt = (int)boxedInt;
        }
    }
}
