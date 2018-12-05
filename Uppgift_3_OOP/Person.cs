using System;
namespace Uppgift_3_OOP
{
    class Person
    {

        #region Fields
        private int age;
        private string fname;
        private string lname;
        private double height;
        private double weight;
        #endregion

        #region Properties
        public int Age { get => age; set => age = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        #endregion

        private Person() { }

        private Person(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            Fname = fname;
            Lname = lname;
            Height = height;
            Weight = weight;
        }

        public static class PersonHandler
        {

            public static Person CreatePerson(int age, string fname, string lname, double height, double weight)
            {
                return new Person(age, fname, lname, height, weight);
            }

            public static Person CreatePerson()
            {
                return new Person();
            }

            public static void SetAge(Person pers, int age)
            {
                pers.Age = age;
            }

        }
    }
}
