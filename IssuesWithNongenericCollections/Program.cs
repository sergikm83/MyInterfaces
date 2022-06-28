using System;
using System.Collections;

namespace IssuesWithNongenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleBoxUnboxOperation();
        }

        static void SimpleBoxUnboxOperation()
        {
            int myInt = 25;
            object boxedInt = myInt;
            int unboxedInt = (int)boxedInt;
            try
            {
                long unboxedLong = (long)boxedInt;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void WorkWithArrayList()
        {
            // Типы значений автоматически упаковываются
            // когда передаются члену, принимающему object
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);
            // Распаковка происходит, когда объект преобразуется
            // обратно в данные, расположенные в стеке
            int i = (int)myInts[0];
            // Теперь значение вновь упаковывается, т.к.
            // метод WriteLine() требует типа object!
            Console.WriteLine("Value of your int: {0}", i);
        }
    }
}
