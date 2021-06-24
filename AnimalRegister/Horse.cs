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
        public Horse(string name, bool isFoal) : base(name)
        {
            IsFoal = isFoal;
        }
        public override void DoSound()
        {
            Console.WriteLine("Neigh, neigh");
        }
        public override string Stats()
        {
            return $"{IsFoal}";
        }
    }
}
