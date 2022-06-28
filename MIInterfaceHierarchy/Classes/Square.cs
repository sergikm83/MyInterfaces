using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIInterfaceHierarchy.Interfaces;

namespace MIInterfaceHierarchy.Classes
{
    public class Square : IShape
    {
        public int GetNumberOfSides() => 4;
        void IDrawable.Draw() => Console.WriteLine("Driwing square...");
        void IPrintable.Draw() => Console.WriteLine("Drawing square before print.");
        public void Print() => Console.WriteLine("Printing square...");
    }
}
