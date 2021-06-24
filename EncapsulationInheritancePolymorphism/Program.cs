using System;

namespace EncapsulationInheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //var person = new Person();

                //int age = AskForInt();
                //person.Age = age;

                //string firstName = Console.ReadLine();
                //person.FName = firstName;

                //string lastName = Console.ReadLine();
                //person.LName = lastName;

                //double height = AskForDouble();
                //person.Height = height;

                //double weight = AskForDouble();
                //person.Weight = weight;

                var firstPerson = new PersonHandler();
                Console.WriteLine("Enter your age.");
                int age = AskForInt();
                Console.WriteLine("Enter your firstname.");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your lastname.");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter your height.");
                double height = AskForDouble();
                Console.WriteLine("Enter your weight.");
                double weight = AskForDouble();

                var personOne = firstPerson.CreatePerson(age, firstName, lastName, height, weight);
                int newAge = 42;
                firstPerson.SetAge(personOne, newAge);
                Console.WriteLine();
                Console.WriteLine($"Your age is now: {personOne.Age}");
                Console.WriteLine($"Fullname is: {firstPerson.GetFullname(personOne)}");
                Console.WriteLine($"First letters of your fullname: {firstPerson.GetFirstLettersOfFullname(personOne)}");
                PrintChildOrAdult(firstPerson, personOne);

                var secondPerson = new PersonHandler();
                var personTwo = secondPerson.CreatePerson(17, "Maria", "Avagyan", 170, 55);
                Console.WriteLine($"Fullname is: {secondPerson.GetFullname(personTwo)}");
                Console.WriteLine($"First letters of your fullname: {secondPerson.GetFirstLettersOfFullname(personTwo)}");
                PrintChildOrAdult(secondPerson, personTwo);

                var thirdPerson = new PersonHandler();
                var personThree = thirdPerson.CreatePerson(34, "John", "Smith", 181, 75);
                Console.WriteLine($"Fullname is: {thirdPerson.GetFullname(personThree)}");
                Console.WriteLine($"First letters of your fullname: {thirdPerson.GetFirstLettersOfFullname(personThree)}");
                PrintChildOrAdult(thirdPerson, personThree);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintChildOrAdult(PersonHandler personHandler, Person person)
        {
            if (personHandler.IsChild(person))
            { Console.WriteLine($"{person.FName} {person.LName} is a child."); }
            else
            { Console.WriteLine($"{person.FName} {person.LName} is an adult."); }

        }

        private static int AskForInt()
        {
            bool isInt = false;
            int answer;
            do
            {
                string userCount = Console.ReadLine();
                isInt = int.TryParse(userCount, out answer);

            } while (!isInt);

            return answer;
        }
        private static double AskForDouble()
        {
            bool isInt = false;
            double answer;
            do
            {
                string userCount = Console.ReadLine();
                isInt = double.TryParse(userCount, out answer) && answer > 0;

            } while (!isInt);

            return answer;
        }
    }
}
