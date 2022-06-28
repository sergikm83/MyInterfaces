using System;
using System.Collections;
using CustomEnumeratorWithYield.Classes;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the Yield Keyword *****\n");
            Garage carLot = new Garage();

            // Получить элементы, используя GetEnumerator().
            foreach(Car c in carLot)
                Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");

            Console.WriteLine();

            // Получить элементы (в обратном порядке
            // с применением именованного итератора
            foreach(Car c in carLot.GetTheCars(returnReversed: true))
                Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");
        }
    }
}
