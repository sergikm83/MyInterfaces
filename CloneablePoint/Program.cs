using System;
using CloneablePoint.Classes;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Cloning *****\n");
            // Две ссылки на один и тот же объект
            Point p1 = new Point(xPos: 50, yPos: 50);
            Point p2 = p1;
            p2.X = 0;
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Point p3 = new Point(xPos: 100, yPos: 100);
            Point p4 = (Point)p3.Clone();
            p4.X = 0;
            Console.WriteLine(p3);
            Console.WriteLine(p4);
        }
    }
}
