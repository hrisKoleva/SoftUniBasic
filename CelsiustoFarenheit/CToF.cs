using System;

namespace CelsiustoFarenheit
{
    class CToF
    {
        static void Main(string[] args)
        {
            var degreesInCelsius = double.Parse(Console.ReadLine());
            var degreesInFarenheit = degreesInCelsius*9/5 + 32.00;
            Console.WriteLine(Math.Round(degreesInFarenheit,2));
            Console.ReadLine();
        }
    }
}