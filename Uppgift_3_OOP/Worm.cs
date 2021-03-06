﻿using System;
namespace Uppgift_3_OOP
{
    public class Worm : Animal
    {
        private bool isPoisonous;

        public Worm()
        {
        }

        public bool IsPoisonous { get => isPoisonous; set => isPoisonous = value; }

        public override string Stats()
        {
            return $"{base.Stats()} Is poisonous: {IsPoisonous}";
        }
    }
}
