using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    //Abstract class #3
    class Primate : Mammal
    {
        public override string Name { get; set; }
        public override int Age { get; set; }

        //Virtual property 2/2
        public virtual bool HasTail
        {
            get
            {
                return true;
            }
            set
            {
                HasTail = value;
            }
        }

        //Virtual method 2/2
        public virtual string Hangs()
        {
            return "I hang from branches";
        }

        public override string Eats()
        {
            return "Primate food";
        }

        public override string Sound()
        {
            return "Primate sound!";
        }
    }
}
