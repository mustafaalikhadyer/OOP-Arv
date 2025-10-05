using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name = "Buddy", int age = 3, double weight = 25, string color = "Brown", string habitat = "Domestic", string breed = "Mixed")
            : base(name, age, weight, color, habitat)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} barks!");
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching a stick!");
        }
    }
}