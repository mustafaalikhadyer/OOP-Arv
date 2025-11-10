using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string Habitat { get; set; }

        public Animal(string name = "Unknown", int age = 0, double weight = 0, string color = "Unknown", string habitat = "Unknown")
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = color;
            Habitat = habitat;
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} is moving.");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a generic animal sound.");
        }
    }
}
