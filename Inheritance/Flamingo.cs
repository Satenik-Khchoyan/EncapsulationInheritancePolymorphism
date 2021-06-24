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
        public Flamingo(string name, double wingSpan, int flamingoAge) : base(name, wingSpan)
        {
            FlamingoAge = flamingoAge; 
        }
        
    }
}
