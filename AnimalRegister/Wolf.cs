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

        public Wolf(string name, int age, double weight, WolfColor color) : base(name, age, weight)
        {
            Color = color;
        }
        public override void DoSound()
        {
            Console.WriteLine("Howl, howl");
        }
        public override string Stats()
        {
            return $"{base.Stats()} {Color}";
        }
    }
}
