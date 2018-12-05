using System;

namespace Uppgift_3_OOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            Person p1 = Person.PersonHandler.CreatePerson();

            //Set age to person through the PersonHandler class.
            Person.PersonHandler.SetAge(p1, 100);



        }
    }
}
