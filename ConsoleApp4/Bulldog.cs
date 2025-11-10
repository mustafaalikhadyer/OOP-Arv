using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Bulldog : Dog
    {
        public bool Snoring { get; set; }

        public Bulldog(string name = "Brutus", int age = 4, double weight = 30, string color = "White", bool snoring = true) 
            : base(name, age, weight, color, "Domestic", "Bulldog")
        {
            Snoring = snoring;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} snorts and barks!");
        }

        public void Snore()
        {
            Console.WriteLine($"{Name} is snoring loudly.");
        }
    }
}
