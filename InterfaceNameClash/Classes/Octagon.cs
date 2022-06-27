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
        public void Draw() => Console.WriteLine("Drawing the Octagon...");
    }
}
