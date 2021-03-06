using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceHierarchy.Interfaces;

namespace InterfaceHierarchy.Classes
{
    public class BitmapImage : IAdvancedDraw
    {
        public void Draw() => Console.WriteLine("Drawing...");
        public void DrawInBoundingBox(int top, int left, int bottom, int right)
            => Console.WriteLine($"Drawing in a box...\nPoints: [x1={left}, y1={top}], [x2={right}, y2={bottom}]");
        public void DrawUpsideDown() => Console.WriteLine("Drawing upside down!");
    }
}
