using System;

namespace WineHarvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMetersArea = int.Parse(Console.ReadLine());
            double kilogramsPerSquareMeter = double.Parse(Console.ReadLine());
            int wineGoalInLitres = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            double kilograms = 0.4 * squareMetersArea * kilogramsPerSquareMeter;
            double litres = kilograms/2.5;

            if( litres < wineGoalInLitres)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineGoalInLitres-litres)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litres)} liters.");
                Console.WriteLine($"{Math.Ceiling(litres-wineGoalInLitres)} liters left -> {Math.Ceiling((litres - wineGoalInLitres)/numberOfWorkers)} liters per person.");
            }

        }
    }
}
