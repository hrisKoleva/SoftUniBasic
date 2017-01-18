using System;

namespace CircleAreAndPerimeter
{
    class CircleAreaPerimeter
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = {0}", Math.PI * radius * radius);
            Console.WriteLine("Perimeters = {0}", 2 * Math.PI * radius);
            Console.ReadLine();
        }
    }
}
