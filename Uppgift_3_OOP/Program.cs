using System;

namespace Uppgift_3_OOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person();

            //Cannot access the fields in the class Person due to their access modifier is private e.g:
            //p1.age = 10;
            //var fname = p1.fname;
        }
    }
}
