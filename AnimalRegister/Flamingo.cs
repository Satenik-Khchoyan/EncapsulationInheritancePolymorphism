using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Flamingo : Bird
    {
        public int FlamingoAge { get; set; }
        public Flamingo(string name, int age, double weight, double wingSpan, int flamingoAge) : base(name, age, weight, wingSpan)
        {
            FlamingoAge = flamingoAge; 
        }

        public override string Stats()
        {
            return base.Stats() + $"{FlamingoAge}";
        }

    }
}
