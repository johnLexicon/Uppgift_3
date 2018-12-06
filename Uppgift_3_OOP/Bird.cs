using System;
namespace Uppgift_3_OOP
{
    public class Bird : Animal
    {
        private int wingSpan;

        public Bird()
        {
        }

        public int WingSpan { get => wingSpan; set => wingSpan = value; }

        public override string Stats()
        {
            return $"{base.Stats()} WingSpan: {WingSpan}";
        }
    }
}
