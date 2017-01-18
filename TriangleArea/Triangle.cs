using System;

namespace TriangleArea
{
    class Triangle
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var area = a * h / 2;

            Console.WriteLine("Triangle area = " + Math.Round(area,2));
            Console.ReadLine();
        }
    }
}
