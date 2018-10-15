using System;
using System.Collections.Generic;
using System.Text;

namespace IBuiltAZoo.Classes
{
    //Abstract class 1/3
    abstract class Mammal
    {  
        //Abstract property 1/2
        public abstract string Name { get; set; }
        //Abstract property 2/2
        public abstract int Age { get; set; }
        //Abstract method 1/2
        public abstract string Eats();
        //Virtual method 1/2
        public virtual string Sound()
        {
            return "Mammal sound!";
        }
    }
}
