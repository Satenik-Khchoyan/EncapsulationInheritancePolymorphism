using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Pelican : Bird
    {
        public string Type { get; set; }
        public Pelican(string name, int age, double weight, double wingSpan, string type) : base(name, age, weight, wingSpan)
        {
            Type = type;
        }

        public override string Stats()
        {
            return base.Stats() + $"{Type}";
        }
    }
}
