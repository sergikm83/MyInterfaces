using System;
using InterfaceHierarchy.Interfaces;
using InterfaceHierarchy.Classes;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Interface Hierarchy *****\n");
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150);
            myBitmap.DrawUpsideDown();

            IAdvancedDraw iAdvDraw = myBitmap as IAdvancedDraw;
            if (iAdvDraw != null)
                iAdvDraw.DrawUpsideDown();
        }
    }
}
