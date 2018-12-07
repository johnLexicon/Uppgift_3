using System;
namespace Uppgift_3_OOP
{
    internal class Person
    {

        #region Fields
        //3.1.1
        private int age;
        private string fname;
        private string lname;
        private double height;
        private double weight;
        #endregion

        #region Properties
        private int Age { get => age; set => age = value; }
        private string Fname { get => fname; set => fname = value; }
        private string Lname { get => lname; set => lname = value; }
        private double Height { get => height; set => height = value; }
        private double Weight { get => weight; set => weight = value; }
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

        //3.1.2
        /// <summary>
        /// Nested class used to handle the Person class (Factory pattern?).
        /// </summary>
        public static class PersonHandler
        {

            //3.1.3
            public static Person CreatePerson(int age, string fname, string lname, double height, double weight)
            {
                return new Person(age, fname, lname, height, weight);
            }

            public static Person CreatePerson()
            {
                return new Person();
            }

            //3.1.4
            public static void SetAge(Person p, int age) => p.Age = age;
            public static int GetAge(Person p) => p.Age;

            public static void SetFname(Person p, string fname) => p.Fname = fname;
            public static string GetFname(Person p) => p.Fname;

            public static void SetLname(Person p, string lname) => p.Lname = lname;
            public static string GetLname(Person p) => p.Lname;

            public static void SetHeight(Person p, double height) => p.Height = height;
            public static double GetHeight(Person p) => p.Height;

            public static void SetWeight(Person p, double weight) => p.Weight = weight;
            public static double GetWeight(Person p) => p.Weight;
        }
    }
}
