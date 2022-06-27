using System;
using MyInterfaces.Classes;

namespace MyInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with Interfaces *****\n");
            Shape[] shapes = {new Hexagon(),new Circle(), new Triangle("Petya"),
                new ThreeDCircle("Vasya"), new Rectangle("Edik")};
            IPointy firstPointyItem = FindFirstPointyShape(shapes);
            Console.WriteLine("The item has {0} points", firstPointyItem.Points);
            Console.WriteLine();
            for (int i=0;i<shapes.Length;i++)
            {
                shapes[i].Draw();
                if (shapes[i] is IPointy ip)
                    Console.WriteLine("-> Points: {0}",ip.Points);
                else
                    Console.WriteLine("-> {0}\'s not pointy", shapes[i].PetName);
                if (shapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)shapes[i]);
                Console.WriteLine();
            }
        }

        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape shape in shapes)
                if (shape is IPointy ip)
                    return ip;
            return null;
        }
    }
}
