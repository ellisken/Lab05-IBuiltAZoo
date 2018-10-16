using System;
using System.Collections.Generic;
using System.Text;
using IBuiltAZoo.Interfaces;

namespace IBuiltAZoo.Classes
{
    class Chimpanzee : Primate, ICanSwim, ICanGroom
    {
        public override string Name
        {
            get
            {
                return "Chimpanzee";
            }
        }

        //Virtual property override 2/2
        public override bool HasTail
        {
            get
            {
                return false;
            }
        }

        public override string Eats()
        {
            return "Chimp food";
        }

        public override string Sound()
        {
            return "Hoo hoo, ha ha";
        }

        public string DryOff()
        {
            return "I dry off by doing a little dance.";
        }

        public string EatFoundBug()
        {
            return "Yum! I found a bug in your fur";
        }

        public string Groom()
        {
            return "I'm looking in your fur for bugs.";
        }

        public string Swim()
        {
            return "Scientists have proven I'm capable of swimming.";
        }
    }
}
