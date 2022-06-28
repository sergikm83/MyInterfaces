using System;
using System.Collections;
using System.Collections.Generic;

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
        static void UsePersonCollection()
        {
            Console.WriteLine("***** Custom Person Collection *****\n");
            PersonCollection myPeole = new PersonCollection();
            myPeole.AddPerson(new Person(firstName: "Homer", lastName: "Simpson", age: 40));
            myPeole.AddPerson(new Person(firstName: "Marge", lastName: "Simpson", age: 38));
            myPeole.AddPerson(new Person(firstName: "Lisa", lastName: "Simpson", age: 9));
            myPeole.AddPerson(new Person(firstName: "Bart", lastName: "Simpson", age: 7));
            myPeole.AddPerson(new Person(firstName: "Maggie", lastName: "Simpson", age: 2));
            // Это вызовет ошибку на этапе компиляции!
            // myPeople.AddPerson(new Car());
            foreach(Person p in myPeole)
                Console.WriteLine(p);
        }
        static void UseGenericList()
        {
            Console.WriteLine("***** Fun with Generics *****\n");
            // Этот объект List<> может хранить только объекты Person.
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person(firstName: "Fank", lastName: "Black", age: 50));
            Console.WriteLine(morePeople[0]);
            // Этот List<> может хранить только целые числа.
            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(2);
            int sum = moreInts[0] + moreInts[1];
            // Ошибка на этапе компиляции! Объект Person
            // не может быть добавлен в списко элементов int
            // moreInts.Add(new Person());
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
