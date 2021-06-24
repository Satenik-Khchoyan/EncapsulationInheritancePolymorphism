using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        // Om samtliga fåglar ska behöva ett nytt attribut vi bör lägga det i klassen Bird.
        //Om alla djur ska behöva det attributet så bör vi lägga det i Animal klassen.
        static void Main(string[] args)
        {
            
            List<Animal> animals = new List<Animal>();
            animals.Add(new Horse("Horse", 10, 80, false));
            animals.Add(new Hedgehog("Hedgehog", 3, 5, 250));
            animals.Add(new Wolf("Wolf", 5, 20, WolfColor.Grey));
            animals.Add(new Worm("Worm", 1, 0.02, true));
            animals.Add(new Bird("Bird", 2, 3, 3));
            animals.Add(new Dog("Dog", 3, 25, "Akita"));
            animals.Add(new Wolfman("Wolfman", 17, 68, WolfColor.White));

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
                animal.DoSound();
            }
            for (int i = 0; i < animals.Count; i++)
            {
                if(animals[i] is IPerson)
                {
                    var pers =animals[i] as IPerson;
                    pers.Talk();
                }
            }

            List<Dog> dogs = new List<Dog>();
            //dogs.Add(new Horse()); det här är fel eftersom de är olika objekter. Båda är djur men en hund är inte en häst.
            // Listan ska vara i typen av Animal för att vi ska kunna laggra alla djur


            foreach (var animal in animals)
            {
                //Stats() har vi gjort override i subklasser. Så här kommer för varje animal kalla sin egen implementation av Stats()
                //Och det kommer returnera varje gång egenskaper av det djuret den blir kallat för 
                Console.WriteLine(animal.Stats());
                
            }

            foreach (var animal in animals)
            {
                if(animal is Dog)
                {
                    Console.WriteLine(animal.Stats());

                    //Vi kan inte komma åt Hungry() metoden som finns i Dog klassen genom animals.
                    //Så vi kan inte skriva animal.Hungry() eftersom bas klassen ser inte vad subklasserna har
                    

                    //Vi når Dog klassens Hungry() metoden via cast

                    var dog = animal as Dog;
                    Console.WriteLine( dog.Hungry()); 
                }
            }
            
        }
    }
}
