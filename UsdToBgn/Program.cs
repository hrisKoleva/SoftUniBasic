using System;

namespace UsdToBgn
{
    class Program
    {
        static void Main(string[] args)
        {
            var usDollars = double.Parse(Console.ReadLine());
            const double rate = 1.79549;
            var bulgarianLeva = usDollars * rate;

            Console.WriteLine(Math.Round(bulgarianLeva, 2) + " BGN");
            Console.ReadLine();
        }
    }
}
