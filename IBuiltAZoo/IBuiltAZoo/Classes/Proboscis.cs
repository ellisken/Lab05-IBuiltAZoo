using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    class Proboscis : Primate
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
    }
}
