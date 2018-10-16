using System;
using System.Collections.Generic;
using System.Text;
using IBuiltAZoo.Interfaces;

namespace IBuiltAZoo.Classes
{
    class Proboscis : Primate, ICanGroom
    {
        public override string Name
        {
            get
            {
                return "Proboscis Monkey";
            }
        }

        public override string Eats()
        {
            return "Unripe fruit!";
        }

        public override string Sound()
        {
            return "Proboscis sound!";
        }

        public string Groom()
        {
            return "I can also groom.";
        }

        public string EatFoundBug()
        {
            return "I like eating bugs that I find in fur.";
        }
    }
}
