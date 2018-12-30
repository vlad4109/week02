using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Program
    {
        public static void PrintTheDogs(Dog[] dogs)
        {
            foreach(Dog dog in dogs)
            {
                Console.WriteLine($"Dog {dog.Name} is a {dog.Sex} and it has {dog.Age} years.");
            }
        }

        public static void PrintTheFrogs(Frog[] frogs)
        {
            foreach (Frog frog in frogs)
            {
                Console.WriteLine($"Frog {frog.Name} is a {frog.Sex} and it has {frog.Age} years.");
            }
        }

        public static void PrintTheCats(Cat[] cats)
        {
            foreach (Cat cat in cats)
            {
                Console.WriteLine($"Cat {cat.Name} is a {cat.Sex} and it has {cat.Age} years.");
            }
        }

        public static double AverageAge()
        {

        }

        static void Main(string[] args)
        {
            Dog[] dogs = new Dog[2];
            Dog d1 = new Dog("Bella", "female", 4);
            dogs[0] = d1;
            Dog d2 = new Dog("Dolly", "female", 8);
            dogs[1] = d2;

            PrintTheDogs(dogs);
            Console.WriteLine();

            Frog[] frogs = new Frog[2];
            Frog f1 = new Frog("Bulbasaur", "male", 3);
            frogs[0] = f1;
            Frog f2 = new Frog("Froggy", "female", 2);
            frogs[1] = f2;

            PrintTheFrogs(frogs);
            Console.WriteLine();

            Cat[] cats = new Cat[2];
            Cat c1 = new Cat("Tom", "male", 5);
            cats[0] = c1;
            Cat c2 = new Cat("Shatzi", "female", 4);
            cats[1] = c2;

            PrintTheCats(cats);
            Console.WriteLine();


        }
    }
}
