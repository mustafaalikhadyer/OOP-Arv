using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Chihuahua : Dog
    {
        public bool IsNervous { get; set; }

        public Chihuahua(string name = "Tiny", int age = 2, double weight = 2.5, string color = "Tan", bool isNervous = true)
            : base(name, age, weight, color, "Domestic", "Chihuahua")
        {
            IsNervous = isNervous;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} yaps nervously!");
        }

        public void Shake()
        {
            Console.WriteLine($"{Name} is shaking nervously.");
        }
    }
}
