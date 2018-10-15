using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    class Grizzly : Bear
    {
        public override string Name
        {
            get
            {
                return "Grizzly";
            }
        }

        //Abstract method override 2/2
        public override bool Hunts()
        {
            return true;
        }

        public override string Eats()
        {
            return "I eat salmon and berries!";
        }
    }
}
