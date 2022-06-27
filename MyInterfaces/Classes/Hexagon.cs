using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterfaces.Classes
{
    public class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw() => Console.WriteLine("Drawing {0} is a Hexagon", PetName);
        public byte Points => 6;
        public void Draw3D() => Console.WriteLine("Drawing Hexagon in 3D your bunny wrote!!!");
    }
}
