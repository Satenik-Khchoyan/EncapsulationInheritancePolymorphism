using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The age cannot be negative!");
                }
                else
                {
                    age = value;
                }

            }
        }
        public string FName
        {
            get
            {
                return fName;
            }
            
            set
            {
                if(value.Length<2 || value.Length >10 || value.Equals(null))
                {
                    throw new ArgumentException("The first name cannot be null and it should contain more that 2 and less that 10 characters");
                }
                else
                {
                    fName = value;
                }
            }
        }
        public string LName 
        {
            get
            {
                return lName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 15 || value.Equals(null))
                {
                    throw new ArgumentException("The last name cannot be null and it should contain more that 3 and less that 15 characters");
                }
                else
                {
                    lName = value;
                }
            }
        }
        public double Height { get; set; }
        public double Weight { get; set; }

       

    }
}
