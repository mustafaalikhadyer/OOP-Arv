using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal("MysteryAnimal", 1, 10, "Green", "Unknown");
            genericAnimal.MakeSound();

            Lion simba = new Lion();
            simba.MakeSound();
            simba.Hunt();

            Elephant dumbo = new Elephant();
            dumbo.MakeSound();
            dumbo.SprayWater();

            Dog doggo = new Dog();
            doggo.MakeSound();
            doggo.Fetch();

            Bulldog brutus = new Bulldog();
            brutus.MakeSound();
            brutus.Snore();

            Chihuahua tiny = new Chihuahua();
            tiny.MakeSound();
            tiny.Shake();
        }
    }
}
