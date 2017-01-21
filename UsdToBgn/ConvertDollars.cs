using System;

namespace UsdToBgn
{
    class ConvertDollars
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
