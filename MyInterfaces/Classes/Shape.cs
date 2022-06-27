using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterfaces.Classes
{
    public abstract class Shape
    {
        public string PetName { get; set; } = "NoName";
        public Shape() { }
        public Shape(string name) => PetName = name;
        public abstract void Draw();
    }
}
