using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }
        public Hedgehog(string name, int nrOfSpikes) : base(name)
        {
            NrOfSpikes = nrOfSpikes;
        }
        public override void DoSound()
        {
            Console.WriteLine("Snuffle, snuffle"); 
        }        public override string Stats()
        {
            return $"{NrOfSpikes}";
        }    }
}
