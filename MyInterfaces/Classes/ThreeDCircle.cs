using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterfaces.Classes
{
    public sealed class ThreeDCircle : Circle, IDraw3D
    {
        public ThreeDCircle() { }
        public ThreeDCircle(string name) : base(name) { }
        public override void Draw() => Console.WriteLine("Drawing {0} is a ThreeDCircle",PetName);
        public void Draw3D() => Console.WriteLine("Drawing Circle in 3D your bunny wrote!!!");
    }
}
