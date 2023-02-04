using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Shape shape1 = new Shape();   Cannot instantiate because the class is abstract. 
            Cube cube1 = new Cube(2.5);
            cube1.GetInfo();

            Sphere sphere1 = new Sphere(3.0);
            sphere1.GetInfo();


            //creating a list of different shape and...
            Shape[] shapes = { new Sphere(9.5), new Cube(4.3) };

            //Getting info for each element in the list
            foreach(Shape shape in shapes)
            {
                shape.GetInfo();

                Cube icecube = shape as Cube;   //with as keyword, if current shape is a Cube when making it as a Cube it will not be null
                if (icecube == null)
                {
                    Console.WriteLine("This is no Cube");
                }

                if (shape is Cube)  //is keyword an check if the object of a sertain type
                {
                    Console.WriteLine("This is a Cube");
                }
            }

            Object cube2 = new Cube(7); //cube2 is of type object with properties of a Cube
            Cube cube3 = (Cube)cube2;   //cube3 is cube2 cast into type Cube thus it is of type Cube

            Console.WriteLine("{0} has a volume of {1}", cube3.Name , cube3.Volume());

            Console.ReadKey();
        }
    }
}
