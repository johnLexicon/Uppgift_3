using System;
namespace Uppgift_3_OOP
{
    public class Animal
    {

        private string name;
        private double weight;
        private int age;

        public Animal()
        {

        }

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Age { get => age; set => age = value; }
    }
}
