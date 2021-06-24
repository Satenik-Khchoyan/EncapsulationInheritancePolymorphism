using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    public class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;

            return person;
        }

        public string GetFullname(Person person)
        {
            return $"{person.FName} {person.LName}";
        }

        public bool IsChild(Person person)
        {
            return person.Age < 18 ? true : false;
        }

        public string GetFirstLettersOfFullname(Person person)
        {
            return $"{person.FName.First()} {person.LName.First()}";
        }
        
    }
}
