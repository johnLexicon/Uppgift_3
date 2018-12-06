using System;

namespace Uppgift_3_OOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Person p1 = Person.PersonHandler.CreatePerson();

            //Set age to person through the PersonHandler class.
            Person.PersonHandler.SetAge(p1, 75);
            Person.PersonHandler.SetFname(p1, "Kalle");
            Person.PersonHandler.SetLname(p1, "Anka");
            Person.PersonHandler.SetHeight(p1, 75.8);
            Person.PersonHandler.SetWeight(p1, 35.3);

            Console.WriteLine(Person.PersonHandler.GetAge(p1));
            Console.WriteLine(Person.PersonHandler.GetFname(p1));
            Console.WriteLine(Person.PersonHandler.GetLname(p1));
            Console.WriteLine(Person.PersonHandler.GetHeight(p1));
            Console.WriteLine(Person.PersonHandler.GetWeight(p1));
        }
    }
}
