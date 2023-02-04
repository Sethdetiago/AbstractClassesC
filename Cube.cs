using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesC
{
    internal class Cube : Shape
    {
        public double Length { get; set; }
        public Cube(double length)
        {
            Name = "Cube";
            Length = length;
        }

        public override double Volume()
        {
            // throw new NotImplementedException();  When generating automatically this statement is generated.
            return Math.Pow(Length, 3);     // lenth * Length * Length

        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nThe Length of each side is {Length} and the Volume of the {Name} is {Volume()}");
        }
    }
}
