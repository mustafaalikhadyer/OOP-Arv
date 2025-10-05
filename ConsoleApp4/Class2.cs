using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Lion : Animal
    {
        public bool IsAlpha { get; set; }

        public Lion(string name = "Leo", int age = 5, double weight = 190, string color = "Golden", string habitat = "Savannah", bool isAlpha = true)
            : base(name, age, weight, color, habitat)
        {
            IsAlpha = isAlpha;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} roars loudly!");
        }

        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting.");
        }
    }
}