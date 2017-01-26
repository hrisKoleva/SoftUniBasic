using System;

namespace TwoDReactangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double verticalSide = Math.Abs(y2 - y1);
            double horizontalSide = Math.Abs(x2 - x1);

            double area = verticalSide * horizontalSide;
            double perimeter = 2 * (verticalSide + horizontalSide);

            Console.WriteLine("Area = {0}", area);
            Console.WriteLine("Perimeter = {0}", perimeter);
            Console.ReadLine();
        }
    }
}
