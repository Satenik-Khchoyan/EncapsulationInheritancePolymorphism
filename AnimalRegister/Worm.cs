using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public Worm(string name, int age, double weight, bool isPoisonous) : base(name, age, weight)
        {
            IsPoisonous = isPoisonous;
        }
        public override void DoSound()
        {
            Console.WriteLine("Fss, fss");
        }
        public override string Stats()
        {
            return $"{base.Stats()} {IsPoisonous}";
        }
    }
}
