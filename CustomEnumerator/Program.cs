using System;
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
        }
    }
}
