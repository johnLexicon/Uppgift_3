using System;
namespace Uppgift_3_OOP
{
    public class Stork : Bird
    {

        private int babiesDelivered;

        public Stork()
        {
        }

        public int BabiesDelivered { get => babiesDelivered; set => babiesDelivered = value; }
    }
}
