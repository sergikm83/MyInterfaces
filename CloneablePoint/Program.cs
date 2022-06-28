using System;
using CloneablePoint.Classes;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Cloning *****\n");
            Console.WriteLine("Cloned p3 and stored new Point in p4");

            Point p3 = new Point(100, 100, "Jane");
            Point p4 = (Point)p3.Clone();
            Console.WriteLine("Before modification:");
            Console.WriteLine($"p3: {p3}");
            Console.WriteLine($"p4: {p4}");
            p4.desc.PetName = "My new Point";
            p4.X = 9;

            Console.WriteLine("\nChanged p4.desc.PetName and p4.X");
            Console.WriteLine("After modofication:");
            Console.WriteLine($"p3: {p3}");
            Console.WriteLine($"p4: {p4}");

        }
    }
}
