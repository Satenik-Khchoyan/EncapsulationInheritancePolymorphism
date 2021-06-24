using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public enum WolfColor
    {
        White,
        Grey
    }
    public class Wolf : Animal
    {
        public WolfColor Color { get; set; }

        public Wolf(string name, WolfColor color) : base(name)
        {
            Color = color;
        }
        public override void DoSound()
        {
            Console.WriteLine("Howl, howl");
        }
        public override string Stats()
        {
            return $"{Color}";
        }
    }
}
