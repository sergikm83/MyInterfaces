using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceNameClash.Interfaces;

namespace InterfaceNameClash.Classes
{
    public class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToForm.Draw() => Console.WriteLine("Drawing the Octagon to Form...");
        void IDrawToPrinter.Draw() => Console.WriteLine("Drawing the Octagon to Printer...");
        void IDrawToMemory.Draw() => Console.WriteLine("Drawing the Octagon to Memory...");
    }
}
