using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    class Chimpanzee : Primate
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
    }
}
