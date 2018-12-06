using System;
namespace Uppgift_3_OOP
{
    public class Flamingo : Bird
    {
        //grams per day
        private double shrimpConsumption;

        public Flamingo()
        {
        }

        public double ShrimpConsumption { get => shrimpConsumption; set => shrimpConsumption = value; }

        public override string Stats()
        {
            return $"{base.Stats()} Shrimp consumption: {ShrimpConsumption}";
        }
    }
}
