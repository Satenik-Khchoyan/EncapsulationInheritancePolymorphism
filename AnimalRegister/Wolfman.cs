using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, WolfColor color) : base(name, color)
        {
                
        }
        public void Talk()
        {
            Console.WriteLine("Hello! I'm a wolfman.");
        }

    }
}
