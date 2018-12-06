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

        public override string Stats()
        {
            string lifePartnerName = LifePartner is null ? "None" : LifePartner.Name;
            return $"{base.Stats()} Life partner: {lifePartnerName}";
        }
    }
}
