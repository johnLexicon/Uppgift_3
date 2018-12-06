using System;
namespace Uppgift_3_OOP
{
    public class Hedgehog : Animal
    {

        private int nrOfSpikes;

        public Hedgehog()
        {
        }

        public int NrOfSpikes { get => nrOfSpikes; set => nrOfSpikes = value; }

        public override string Stats()
        {
            return $"{base.Stats()} Number of spikes: {NrOfSpikes}";
        }
    }
}
