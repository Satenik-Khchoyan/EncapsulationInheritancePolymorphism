using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Swan : Bird
    {
        public double Height { get; set; }

        public Swan(string name, int age, double weight, double wingSpan, double height): base(name, age, weight, wingSpan)
        {
            Height = height;
        }

        public override string Stats()
        {
            return base.Stats() + $"{Height}";
        }
    }
}
