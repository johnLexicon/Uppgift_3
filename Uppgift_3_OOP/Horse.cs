using System;
namespace Uppgift_3_OOP
{
    public class Horse : Animal
    {

        private bool isRaceHorse;

        public Horse()
        {
        }

        public bool IsRaceHorse { get => isRaceHorse; set => isRaceHorse = value; }
    }
}
