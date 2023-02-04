using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesC
{
    //Cannot create object of type shape since it is abstract
    abstract class Shape
    {

        public string Name { get; set; }

        public virtual void GetInfo()       //Again Virtual methods can be overwritten
        {
            Console.WriteLine($"\nThis is a {Name}");

        }

        public abstract double Volume();    //We will not implement it as it is still abstract (volumes of different shapes are calculated differently)
                                            //volume method will be required for all inhereiting classes

    }
}
