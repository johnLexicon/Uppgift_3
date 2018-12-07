using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3_OOP
{
    internal static class Repository
    {
        internal static List<Animal> RetrieveAnimals()
        {
            return new List<Animal>()
            {
                new Animal()
                {
                    Age = 10,
                    Name = "Animal 1",
                    Weight = 20
                },
                new Animal()
                {
                    Age = 20,
                    Name = "Animal 2",
                    Weight = 30
                },
                new Animal()
                {
                    Age = 30,
                    Name = "Animal 3",
                    Weight = 40
                },
                new Animal()
                {
                    Age = 40,
                    Name = "Animal 4",
                    Weight = 50
                },
                new Animal()
                {
                    Age = 50,
                    Name = "Animal 5",
                    Weight = 60
                },
                new Dog()
                {
                    Age = 6,
                    Name = "Dog 1",
                    Weight = 60,
                    IsDetectionDog = true
                },
                new Dog()
                {
                    Age = 6,
                    Name = "Dog 2",
                    Weight = 60,
                    IsDetectionDog = false
                },
                new Bird()
                {
                    Age = 2,
                    Name = "Bird 1",
                    Weight = 10,
                    WingSpan = 50
                },
                new Swan()
                {
                    Age = 3,
                    Name = "Swan 1",
                    Weight = 80,
                    WingSpan = 20
                }
            };
        }

        internal static List<UserError> RetrieveErrors()
        {
            return new List<UserError>()
            {
                new NumericInputError(),
                new TextInputError(),
                new NumericInputError(),
                new TextInputError(),
                new NumericInputError()
            };
        }
    }
}
