using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    class Lemur : Primate
    {
        public override string Name {
            get
            {
                return "Lemur";
            }
        }

        public override string Eats()
        {
            return "Lemur food";
        }

        public override string Sound()
        {
            return "Lemur sound!";
        }
    }
}
