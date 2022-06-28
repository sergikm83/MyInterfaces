using System;
using System.Collections;

namespace IssuesWithNongenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleBoxUnboxOperation();
        }

        static void SimpleBoxUnboxOperation()
        {
            int myInt = 25;
            object boxedInt = myInt;
            int unboxedInt = (int)boxedInt;
            try
            {
                long unboxedLong = (long)boxedInt;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void WorkWithArrayList()
        {
            // Типы значений автоматически упаковываются
            // когда передаются члену, принимающему object
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);
            // Распаковка происходит, когда объект преобразуется
            // обратно в данные, расположенные в стеке
            int i = (int)myInts[0];
            // Теперь значение вновь упаковывается, т.к.
            // метод WriteLine() требует типа object!
            Console.WriteLine("Value of your int: {0}", i);
        }
        static void ArrayListOfRandomObjects()
        {
            // ArrayList может хранить вообще все что угодно.
            ArrayList allMyObjects = new ArrayList();
            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.Other, new Version(10, 0)));
            allMyObjects.Add(66);
            allMyObjects.Add(3.14);
        }
    }
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString() => $"Name: {FirstName} {LastName}, Age: {Age}";
    }
    public class PersonCollection :IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        // Приведение для вызывающего кода.
        public Person GetPerson(int pos) => (Person)arPeople[pos];
        // Вставка только объектов Person.
        public void AddPerson(Person p) => arPeople.Add(p);
        public void ClearPeople() => arPeople.Clear();
        public int Count => arPeople.Count;
        // Поддержка перечисления с помощью foreach.
        IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();
    }
}
