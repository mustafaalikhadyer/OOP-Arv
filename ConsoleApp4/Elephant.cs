using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Elephant : Animal
    {
        public double TrunkLength { get; set; }

        public Elephant(string name = "Ella", int age = 10, double weight = 3000, string color = "Gray", string habitat = "Forest", double trunkLength = 2.5)
            : base(name, age, weight, color, habitat)
        {
            TrunkLength = trunkLength;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} trumpets loudly!");
        }

        public void SprayWater()
        {
            Console.WriteLine($"{Name} sprays water with its trunk!");
        }
    }
}
