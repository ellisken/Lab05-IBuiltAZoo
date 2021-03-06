﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    //Abstract class 2/3
    public abstract class Bear : Mammal
    {
        //Abstract property override 1/2
        public override string Name
        {
            get
            {
                return "Beary McBearface";
            }
            set
            {
                Name = value;
            }
        }

        //Abstract property override 2/2
        public override int Age
        {
            get
            {
                return 1;
            }
            set
            {
                Age = value;
            }
        }

        //Virtual property 1/2
        public virtual int ClawLength
        {
            get
            {
                return 3;
            }
            set
            {
                ClawLength = value;
            }
        }

        //Abstract method 2/2
        public abstract bool Hunts();

        //Abstract method override 1/2
        public override string Eats()
        {
            return "I eat plants and animals!";
        }

        //Virtual method override 1/1
        public override string Sound()
        {
            return "Roar!!!";
        }
    }
}
