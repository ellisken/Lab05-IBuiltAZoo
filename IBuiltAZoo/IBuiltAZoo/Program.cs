using System;
using IBuiltAZoo.Classes;
using IBuiltAZoo.Interfaces;

namespace IBuiltAZoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my zoo!\n");
            Console.WriteLine("My zoo has an abstract base class called Mammal.\nMammals" +
                " have 1) an abstract name and 2) an abstract age, and can 1) eat (abstract) and 2) make a sound (virtual).\n");

            Console.WriteLine("\n\nHit <ENTER> to continue.");
            Console.ReadLine();

            //Show info about Bears and demo different Bear subclasses
            Console.WriteLine("The class 'Bear' inherits from Mammal and overrides all properties and methods. Bear additionally" +
                " adds a virtual property called ClawLength and an abstract method called Hunts().\n");
            Console.WriteLine("There are three Bear descendent classes: Panda, Grizzly, and PolarBear.");
            Console.WriteLine("Pandas, Grizzlies, and PolarBears override all properties and methods of Bear EXCEPT for: ClawLength, Age, and Sound.");
            Bear[] myBears = CreateBears();

            Console.WriteLine("\n\nHit <ENTER> to see a demonstration of each class that inherits from Bear.");
            Console.ReadLine();
            Console.WriteLine("Here's a demonstration of each bear type\n");
            ShowBears(myBears);
            Console.WriteLine("\n\nHit <ENTER> to continue.");
            Console.ReadLine();


            //Instantiate Primates and return collection of primates
            Console.WriteLine("The class 'Primate' inherits from Mammal and overrides all properties and methods. Primate additionally" +
    " adds a virtual property called HasTail and an virtual method called Hangs().\n");
            Console.WriteLine("There are three Primate descendent classes: Lemur, Chimpanzee, and Proboscis.");
            Console.WriteLine("Lemurs and Proboscii override Name, Eats(), Sound(), while Chimpanzees additionally override HasTail. ");
            Primate[] myPrimates = CreatePrimates();
            Console.WriteLine("\n\nHit <ENTER> to see a demonstration of each class that inherits from Primate.");
            Console.ReadLine();
            Console.WriteLine("Here's a demonstration of each primate type\n");
            ShowPrimates(myPrimates);
            Console.WriteLine("\n\nHit <ENTER> to continue.");
            Console.ReadLine();

            //Show RingTailed
            Console.WriteLine("Additionally, the class RingTailed inherits from Lemur and adds a method called SpendsTime()");
            RingTailed ringTailedLemur = new RingTailed();
            Console.WriteLine($"Name: {ringTailedLemur.Name}");
            Console.WriteLine($"Age: {ringTailedLemur.Age}");
            Console.WriteLine($"Has tail? {ringTailedLemur.HasTail}");
            Console.WriteLine($"Eats: {ringTailedLemur.Eats()}");
            Console.WriteLine($"Sound: {ringTailedLemur.Sound()}");
            Console.WriteLine($"Hangs: {ringTailedLemur.Hangs()}");
            Console.WriteLine($"Spends time: {ringTailedLemur.SpendsTime()}");
            Console.WriteLine();

            //Show Interface Implementation
            Console.WriteLine("Finally, there are two interfaces: ICanSwim and ICanGroom.");
            Console.WriteLine("Chimpanzee implements both, while PolarBear implements ICanSwim");
            Console.WriteLine("\n\nHit <ENTER> to see a demonstration.");
            Console.ReadLine();
            PolarBear pb = new PolarBear();
            Chimpanzee c = new Chimpanzee();
            Console.WriteLine($"calling PolarBear.Swim(): {pb.Swim()}");
            Console.WriteLine($"calling PolarBear.DryOff(): {pb.DryOff()}");
            Console.WriteLine($"calling Chimpanzee.Swim(): {c.Swim()}");
            Console.WriteLine($"calling Chimpanzee.DryOff(): {c.DryOff()}");
            Console.WriteLine($"calling Chimpanzee.Groom(): {c.Groom()}");
            Console.WriteLine($"calling Chimpanzee.EatFoundBug: {c.EatFoundBug()}");
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

        /// <summary>
        /// Displays the properties and behaviors of each Bear
        /// </summary>
        /// <param name="bears">An array of Bears</param>
        public static void ShowBears(Bear[] bears)
        {
            foreach (Bear bear in bears)
            {
                Console.WriteLine($"Name: {bear.Name}");
                Console.WriteLine($"Age: {bear.Age}");
                Console.WriteLine($"Claw length: {bear.ClawLength}");
                Console.WriteLine($"Eats: {bear.Eats()}");
                Console.WriteLine($"Sound: {bear.Sound()}");
                Console.WriteLine($"Hunts? {bear.Hunts()}");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Creates an array of objects that represent each class that inherits from Primate
        /// </summary>
        /// <returns>Array of classes that inherit from Primate</returns>
        public static Primate[] CreatePrimates()
        {
            Primate[] primates = new Primate[3];
            primates[0] = new Lemur();
            primates[1] = new Chimpanzee();
            primates[2] = new Proboscis();
            return primates;
        }

        /// <summary>
        /// Displays the properties and behaviors of each Primate
        /// </summary>
        /// <param name="bears">An array of Primates</param>
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

        //Methods to access private methods in classes for testing
        public static string GetPandaName()
        {
            Panda newPanda = new Panda();
            return newPanda.Name;
        }

        public static bool DoesPandaHunt()
        {
            Panda panda = new Panda();
            return panda.Hunts();
        }

        public static bool DoesGrizzlyHunt()
        {
            Grizzly grizzly = new Grizzly();
            return grizzly.Hunts();
        }

        public static string GrizzlyEats()
        {
            Grizzly grizzly = new Grizzly();
            return grizzly.Eats();
        }

        public static bool DoesPolarHunt()
        {
            PolarBear pb = new PolarBear();
            return pb.Hunts();
        }

        public static int PolarClawLength()
        {
            PolarBear pb = new PolarBear();
            return pb.ClawLength;
        }

        public static string PolarEats()
        {
            PolarBear pb = new PolarBear();
            return pb.Eats();
        }

        public static string LemurEats()
        {
            Lemur l = new Lemur();
            return l.Eats();
        }

        public static string LemurSound()
        {
            Lemur l = new Lemur();
            return l.Sound();
        }

        public static bool DoesChimpHaveTail()
        {
            Chimpanzee c = new Chimpanzee();
            return c.HasTail;
        }

        public static string ChimpSound()
        {
            Chimpanzee c = new Chimpanzee();
            return c.Sound();
        }

        public static bool DoesProbHaveTail()
        {
            Proboscis p = new Proboscis();
            return p.HasTail;
        }

        public static string ProbEats()
        {
            Proboscis p = new Proboscis();
            return p.Eats();
        }

        public static string RTSpendsTime()
        {
            RingTailed rt = new RingTailed();
            return rt.SpendsTime();
        }

        public static string RTName()
        {
            RingTailed rt = new RingTailed();
            return rt.Name;
        }

        public static string ChimpGrooms()
        {
            Chimpanzee c = new Chimpanzee();
            return c.Groom();
        }

        public static string ChimpSwims()
        {
            Chimpanzee c = new Chimpanzee();
            return c.Swim();
        }

        public static string PolarSwims()
        {
            PolarBear p = new PolarBear();
            return p.Swim();
        }

        public static bool ChimpIsMammal()
        {
            Chimpanzee c = new Chimpanzee();
            if (c is Mammal) return true;
            return false;
        }
    }
}
