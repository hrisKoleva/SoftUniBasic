using System;

namespace TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var area = (a + b) * h / 2;
            Console.WriteLine("Trapezoid area = " + area);
            Console.ReadLine();
        }
    }
}
