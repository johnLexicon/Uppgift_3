using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3_OOP
{
    class Dog : Animal
    {
        private bool isDetectionDog;

        public bool IsDetectionDog { get => isDetectionDog; set => isDetectionDog = value; }

        public override string Stats()
        {
            return $"{base.Stats()} Is detection dog: {IsDetectionDog}";
        }

        //3.3.13 Skapa en ny metod med valfritt namn i klassen Dog som endast returnerar en valfri sträng.
        public string TellMeWhatYouAre() => IsDetectionDog ? "I am a working dog" : "I am unemployed";
    }
}
