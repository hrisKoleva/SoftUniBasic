using System;

namespace TwoDReactangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var verticalSide = Math.Abs(y2 - y1);
            var horizontalSide = Math.Abs(x2 - x1);

            var area = verticalSide * horizontalSide;
            var perimeter = 2 * (verticalSide + horizontalSide);

            Console.WriteLine("Area = {0}", area);
            Console.WriteLine("Perimeter = {0}", perimeter);
            Console.ReadLine();
        }
    }
}
