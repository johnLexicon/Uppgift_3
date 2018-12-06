using System;
namespace Uppgift_3_OOP
{
    public class Flamingo : Bird
    {
        //grams/day
        private double shrimpConsumption;

        public Flamingo()
        {
        }

        public double ShrimpConsumption { get => shrimpConsumption; set => shrimpConsumption = value; }
    }
}
