using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar.Classes
{
    public class Car : IComparable
    {
        public const int MaxSpeed = 100;
        public int CarID { get; set; }
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        private bool carIsDead;
        private Radio theMusicBox = new();
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public Car(string name, int speed, int id)
        {
            CurrentSpeed = speed;
            PetName = name;
            CarID = id;
        }
        public void CrunkTunes(bool state) => theMusicBox.TurnOn(state);

        int IComparable.CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp != null)
                return this.CarID.CompareTo(temp.CarID);
            else
                throw new ArgumentException("Parameter is not a Car");
        }
        public static IComparer SortByPetName { get => (IComparer)new PetNameComparer(); }
        public static IComparer SortbyCurrentSpeed { get => (IComparer)new CurrentSpeedComparer(); }
        public void Accelerate(int delta)
        {
            if (delta < 0)
            {
                StringBuilder sb = new StringBuilder("Speed must be greater than zero!");
                for (int i = delta; i < 0; i++)
                    sb.Append($"\n{-1*i:000}: Your bunny wrote");
                throw new ArgumentOutOfRangeException("delta", sb.ToString());
            }
            if (carIsDead)
                Console.WriteLine($"{PetName} is out of order...");
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    // Console.WriteLine($"{PetName} has overheated!");
                    carIsDead = true;
                    CurrentSpeed = 0;
                    CarIsDeadException ex = new CarIsDeadException($"{PetName} has overheated!","You have a lead foot", DateTime.Now);
                    ex.HelpLink = "http://www.CarsRUs.com";
                    throw ex;
                }
                else
                    Console.WriteLine($"=> CurrentSpeed = {CurrentSpeed}");
            }
        }
    }
}
