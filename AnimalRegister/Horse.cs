using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Horse : Animal
    {
        public bool IsFoal { get; set; }
        public Horse(string name, int age, double weight, bool isFoal) : base(name, age, weight)
        {
            IsFoal = isFoal;
        }
        public override void DoSound()
        {
            Console.WriteLine("Neigh, neigh");
        }
        public override string Stats()
        {
            return $"{base.Stats()} {IsFoal}";
        }
    }
}
