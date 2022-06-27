using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterfaces.Classes
{
    public class Rectangle : Shape, IPointy
    {
        public Rectangle() { }
        public Rectangle(string name) : base(name) { }
        public override void Draw() => Console.WriteLine("Drawing {0} is a Rectangle", PetName);
        public byte Points => 4;
    }
}
