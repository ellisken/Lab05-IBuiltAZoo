using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    class Panda : Bear
    {  
        public override string Name
        {
            get
            {
                return "Panda";
            }
        }

        //Abstract method override 2/2
        public override bool Hunts()
        {
            return false;
        }

        public override string Eats()
        {
            return "I eat bamboo!";
        }
    }
}
