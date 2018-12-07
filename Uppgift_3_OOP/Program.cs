using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Uppgift_3_OOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            //3.1.5

            Console.WriteLine("------------------------3.1----------------------");

            Person p1 = Person.PersonHandler.CreatePerson();

            //Set age to person through the PersonHandler class.
            Person.PersonHandler.SetAge(p1, 75);
            Person.PersonHandler.SetFname(p1, "Kalle");
            Person.PersonHandler.SetLname(p1, "Anka");
            Person.PersonHandler.SetHeight(p1, 75.8);
            Person.PersonHandler.SetWeight(p1, 35.3);

            Console.WriteLine(Person.PersonHandler.GetAge(p1));
            Console.WriteLine(Person.PersonHandler.GetFname(p1));
            Console.WriteLine(Person.PersonHandler.GetLname(p1));
            Console.WriteLine(Person.PersonHandler.GetHeight(p1));
            Console.WriteLine(Person.PersonHandler.GetWeight(p1));

            //3.2

            Console.WriteLine("------------------------3.2----------------------");

            Bird b1 = new Swan()
            {
                Age = 10,
                Name = "Bucky",
                Weight = 200,
                WingSpan = 70,
                LifePartner = null
            };

            Bird b2 = new Swan()
            {
                Age = 20,
                Name = "Daisy",
                Weight = 100,
                WingSpan = 36,
                LifePartner = null
            };

            (b1 as Swan).LifePartner = (b2 as Swan);
            (b2 as Swan).LifePartner = (b1 as Swan);

            Console.WriteLine(b1.Stats());

            Console.WriteLine("------------------------3.3----------------------");
            Console.WriteLine();

            List<Animal> animals = Repository.RetrieveAnimals();

            foreach(var animal in animals)
            {
                Console.WriteLine(animal.GetType());
            }

            //Filter dogs
            List<Dog> dogs = animals.OfType<Dog>().ToList<Dog>();

            //3.3.7 = På grund av att de är olika typer. Kan inte konverterar en häst till en hund.
            //3.3.8 = Listan måste vara av typen Animal för att kunna lagra alla typer av djur (eftersom alla ärver från klassen animal).
            //dogs.Add(new Horse());

            //3.3.9 Skriv ut samtliga Animals Stats() genom en foreach loop.
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }

            //F 3.3.11 Stats() är en virtuell metod vilket betyder att metoden som overridar den virtuella metoden blir anropad istället.

            Console.WriteLine();

            //3.3.12 Skriv ut Stats() metoden enbart för alla hundar genom en foreach på Animals.
            foreach (var animal in animals)
            {
                if(animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                }
            }

            //3.3.14 - 3.3.15 Kan inte komma åt metoden i Dog klassen från Animal listan om jag inte typ-castar (down casting) till Dog-typen först e.g.
            //Animal adog = new Dog();
            //((Dog)adog).TellMeWhatYouAre();

            Console.WriteLine();

            //3.3.16 Hitta ett sätt att skriva ut din nya metod för dog genom en foreach på Animals.
            foreach (var animal in animals)
            {
                if(animal is Dog dog)
                {
                    Console.WriteLine(dog.TellMeWhatYouAre());
                }
            }

            Console.WriteLine("------------------------3.4----------------------");
            Console.WriteLine();

            //3.4.8 Skriv ut samtliga UserErrors UEMessage() genom en foreach loop
            foreach (var error in Repository.RetrieveErrors())
            {
                Console.WriteLine(error.UEMessage());
            }

            //3.4.10 Testa och se så det fungerar.
            Console.WriteLine();
            TestNumericInputError();
            Console.WriteLine();
            TestTextInputError();
            Console.WriteLine();
            TestBirdError();
            Console.WriteLine();
            TestDogError();
            Console.WriteLine();
            TestSwanError();
        }

        private static void TestNumericInputError()
        {
            try
            {
                string text = "I have 1 digit";
                bool containsDigits = Regex.IsMatch(text, @"\d+");
                if (containsDigits)
                {
                    throw new CustomException(new NumericInputError());
                }
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void TestTextInputError()
        {
            try
            {
                bool success = int.TryParse("1a3", out int number);
                if (!success)
                {
                    throw new CustomException(new TextInputError());
                }
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }



        private static void TestBirdError()
        {
            try
            {
                Animal horse = new Horse();
                Bird bird = horse as Bird;
                if(bird is null)
                {
                    throw new CustomException(new BirdError());
                }
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void TestDogError()
        {
            try
            {
                Animal cat = new Cat();
                Dog dog = cat as Dog;
                if (dog is null)
                {
                    throw new CustomException(new DogError());
                }
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void TestSwanError()
        {
            try
            {
                Swan swan = new Swan()
                {
                    Age = 10,
                    Name = "Sweeney",
                    LifePartner = null,
                    WingSpan = 20,
                    Weight = 25
                };

                try
                {
                    Console.WriteLine(swan.LifePartner.Stats());
                }
                catch(NullReferenceException)
                {
                    throw new CustomException(new SwanError());
                }
                
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
