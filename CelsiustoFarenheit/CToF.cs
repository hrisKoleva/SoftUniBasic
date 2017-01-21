using System;

namespace CelsiustoFarenheit
{
    class CToF
    {
        static void Main(string[] args)
        {
            double degreesInCelsius = double.Parse(Console.ReadLine());
            double degreesInFarenheit = degreesInCelsius*9/5 + 32.0;
            Console.WriteLine(Math.Round(degreesInFarenheit,2));
            Console.ReadLine();
        }
    }
}