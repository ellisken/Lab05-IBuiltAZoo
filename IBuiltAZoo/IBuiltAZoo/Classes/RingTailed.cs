using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    class RingTailed : Lemur
    {
        public override string Name
        {
            get
            {
                return "Ring Tailed Lemur";
            }
        }

        public string SpendsTime()
        {
            return "on the ground!";
        }
    }
}
