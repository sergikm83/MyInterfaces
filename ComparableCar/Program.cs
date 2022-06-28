using System;
using ComparableCar.Classes;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Sorting *****\n");
            // Создать массив объектов Car.
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Mary", 40, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chucky", 40, 5);
            // Отобразить текущее содержимое массива
            Console.WriteLine("Here is the unordered set of cars:");
            foreach(Car c in myAutos)
                Console.WriteLine($"{c.CarID} {c.PetName}");
            // Теперь отсортировать массив с применением IComparable!
            Array.Sort(myAutos);
            Console.WriteLine();
            // Отобразить отсортированное содержимое массива
            foreach (Car c in myAutos)
                Console.WriteLine($"{c.CarID} {c.PetName}");
        }
    }
}
