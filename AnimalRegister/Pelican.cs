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
        public Pelican(string name, double wingSpan, string type) : base(name, wingSpan)
        {
            Type = type;
        }
    }
}
