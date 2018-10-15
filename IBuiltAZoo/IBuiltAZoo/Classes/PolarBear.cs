using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    class PolarBear : Bear
    {
        public override string Name
        {
            get
            {
                return "Polar Bear";
            }
        }

        //Abstract method override 2/2
        public override bool Hunts()
        {
            return true;
        }

        public override string Eats()
        {
            return "I eat seals!";
        }
    }
}
