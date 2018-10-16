using System;
using System.Collections.Generic;
using System.Text;
using IBuiltAZoo.Interfaces;

namespace IBuiltAZoo.Classes
{
    class PolarBear : Bear, ICanSwim
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

        public string Swim()
        {
            return "I'm swimming in frigid water";
        }

        public string DryOff()
        {
            return "I shake myself to dry off.";
        }
    }
}
