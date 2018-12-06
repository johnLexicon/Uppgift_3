using System;
namespace Uppgift_3_OOP
{
    public class Cat : Animal
    {

        private int numberOfLivesLeft;

        public Cat()
        {
        }

        public int NumberOfLivesLeft { get => numberOfLivesLeft; set => numberOfLivesLeft = value; }

        public override string Stats()
        {
            return $"{base.Stats()} Number of lives left: {NumberOfLivesLeft}";
        }
    }
}
