using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class AnimalKingdom
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Balkan", 9, Animal.Gender.Male));
            dogs.Add(new Dog("Laika", 13, Animal.Gender.Female));
            dogs.Add(new Dog("Rexi", Animal.Gender.Female));
            dogs.Add(new Dog("Sharo", Animal.Gender.Male));

            Console.WriteLine("The avarage age of all dogs is {0:0.00}", Animal.AvarageAge(dogs));

            List<Cat> cats = new List<Cat>();
            cats.Add(new Tomcat("Tom", 7));
            cats.Add(new Kitten("Maca", 4));
            cats.Add(new Cat("Pisana", 2, Animal.Gender.Female));

            Console.WriteLine("The avarage age of all cats is {0:0.00}", Animal.AvarageAge(cats));

            List<Frog> frogs = new List<Frog>();
            frogs.Add(new Frog("Kermit", 5, Animal.Gender.Male));
            frogs.Add(new Frog("Princess", 3, Animal.Gender.Female));

            Console.WriteLine("The avarage age of all frogs is {0:0.00}", Animal.AvarageAge(frogs));

            var animals = cats.Concat<Animal>(dogs).Concat<Animal>(frogs);

            Console.WriteLine("The avarage age of all animals in the Animal Kingdom is {0:0.00}", Animal.AvarageAge(animals));
        }
    }
}
