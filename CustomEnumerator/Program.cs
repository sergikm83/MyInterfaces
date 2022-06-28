using System;
using System.Collections;
using CustomEnumerator.Classes;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with IEnumerable / IEnumerator *****\n");
            Garage carLot = new Garage();

            foreach(Car c in carLot)
                Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");
            IEnumerator i = carLot.GetEnumerator();
            i.MoveNext();
            Car myCar = (Car)i.Current;
            Console.WriteLine("{0} is going {1} MPH",myCar.PetName,myCar.CurrentSpeed);
        }
    }
}
