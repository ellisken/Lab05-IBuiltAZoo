using System;
using IBuiltAZoo.Classes;

namespace IBuiltAZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my zoo!\n");
            Console.WriteLine("My zoo has an abstract base class called Mammal.\nMammals" +
                " have 1) an abstract name and 2) an abstract age, and can 1) eat (abstract) and 2) make a sound (virtual).\n");

            //Show info about Bears and demo different Bear subclasses
            Console.WriteLine("The class 'Bear' inherits from Mammal and overrides all properties and methods. Bear additionally" +
                " adds a virtual property called ClawLength and an abstract method called Hunts().\n");
            Console.WriteLine("There are three Bear descendent classes: Panda, Grizzly, and PolarBear.");
            Console.WriteLine("Pandas, Grizzlies, and PolarBears override all properties and methods of Bear EXCEPT for: ClawLength, Age, and Sound.");
            Bear[] myBears = CreateBears();
            Console.WriteLine("Here's a demonstration of each bear type ");
            ShowBears(myBears);


            //Instantiate Primates and return collection of primates
            Console.WriteLine("The class 'Primate' inherits from Mammal and overrides all properties and methods. Primate additionally" +
    " adds a virtual property called HasTail and an virtual method called Hangs().\n");
            Console.WriteLine("There are three Primate descendent classes: Lemur, Chimpanzee, and Proboscis.");
            Console.WriteLine("Lemurs and Proboscii override Name, Eats(), Sound(), while Chimpanzees additionally override HasTail. ");
            Primate[] myPrimates = CreatePrimates();
            Console.WriteLine("Here's a demonstration of each primate type ");
            ShowPrimates(myPrimates);
        }

        /// <summary>
        /// Creates an array of objects that represent each class that inherits from Bear
        /// </summary>
        /// <returns>Array of classes that inherit from Bear</returns>
        public static Bear[] CreateBears()
        {
            Bear[] bears = new Bear[3];
            bears[0] = new Panda();
            bears[1] = new Grizzly();
            bears[2] = new PolarBear();
            return bears;
        }

        public static void ShowBears(Bear[] bears)
        {
            foreach (Bear bear in bears)
            {
                Console.WriteLine($"Name: {bear.Name}");
                Console.WriteLine($"Age: {bear.Age}");
                Console.WriteLine($"Claw length: {bear.ClawLength}");
                Console.WriteLine($"Eats: {bear.Eats()}");
                Console.WriteLine($"Sound: {bear.Sound()}");
                Console.WriteLine();
            }
        }

        public static Primate[] CreatePrimates()
        {
            Primate[] primates = new Primate[3];
            primates[0] = new Lemur();
            primates[1] = new Chimpanzee();
            primates[2] = new Proboscis();
            return primates;
        }

        public static void ShowPrimates(Primate[] primates)
        {
            foreach (Primate primate in primates)
            {
                Console.WriteLine($"Name: {primate.Name}");
                Console.WriteLine($"Age: {primate.Age}");
                Console.WriteLine($"Has tail? {primate.HasTail}");
                Console.WriteLine($"Eats: {primate.Eats()}");
                Console.WriteLine($"Sound: {primate.Sound()}");
                Console.WriteLine($"Hangs: {primate.Hangs()}");
                Console.WriteLine();
            }
        }
    }
}
