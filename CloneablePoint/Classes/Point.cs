using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint.Classes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }

        public override string ToString() => $"X = {X}; Y = {Y}";
    }
}
