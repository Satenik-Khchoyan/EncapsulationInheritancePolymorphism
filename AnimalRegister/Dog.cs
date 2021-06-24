using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Dog : Animal
    {

        public string Type { get; set; }
        public Dog(string name, int age, double weight, in string type) : base(name, age, weight)
        {
            Type = type;
        }
        public override void DoSound()
        {
            Console.WriteLine("Woh, woh");
        }

        public override string Stats()
        {
            return $"{base.Stats()} {Type}";
        }

        public string Hungry()
        {
            return "I am very hungry!";
        }
    }
}
