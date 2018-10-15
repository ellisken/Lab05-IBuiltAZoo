using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    class Panda : Bear
    {
        Panda(int age)
        {
            Age = age;
        }

        
        public override string Name
        {
            get
            {
                return "Panda";
            }
            set { }
        }

        public override int Age
        {
            get
            {
                return Age;
            }
            set { }
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
