using System;
using InterfaceNameClash.Classes;
using InterfaceNameClash.Interfaces;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****\n");
            Octagon octagon = new Octagon();

            IDrawToForm itfForm = (IDrawToForm)octagon;
            itfForm.Draw();

            IDrawToMemory itfMemory = (IDrawToMemory)octagon;
            itfMemory.Draw();

            IDrawToPrinter itfPrinter = (IDrawToPrinter)octagon;
            itfPrinter.Draw();
        }
    }
}
