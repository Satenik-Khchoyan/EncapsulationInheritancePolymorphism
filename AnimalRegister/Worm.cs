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
        public Worm(string name, bool isPoisonous) : base(name)
        {
            IsPoisonous = isPoisonous;
        }
        public override void DoSound()
        {
            Console.WriteLine("Fss, fss");
        }
        public override string Stats()
        {
            return $"{IsPoisonous}";
        }
    }
}
