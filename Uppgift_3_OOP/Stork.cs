using System;
namespace Uppgift_3_OOP
{
    public class Stork : Bird
    {

        private int nrOfbabiesDelivered;

        public Stork()
        {
        }

        public int NrOfBabiesDelivered { get => nrOfbabiesDelivered; set => nrOfbabiesDelivered = value; }

        public override string Stats()
        {
            return $"{base.Stats()} Number of babies delivered: {NrOfBabiesDelivered}";
        }
    }
}
