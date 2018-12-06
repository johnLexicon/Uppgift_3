using System;
namespace Uppgift_3_OOP
{
    public class Swan : Bird
    {

        private Swan lifePartner;

        public Swan()
        {
        }

        public Swan LifePartner { get => lifePartner; set => lifePartner = value; }
    }
}
