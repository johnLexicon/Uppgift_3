using System;
namespace Uppgift_3_OOP
{
    public class Worm : Animal
    {
        private bool isPoisonous;

        public Worm()
        {
        }

        public bool IsPoisonous { get => isPoisonous; set => isPoisonous = value; }
    }
}
