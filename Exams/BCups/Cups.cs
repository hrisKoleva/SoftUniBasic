using System;

namespace BCups
{
    class Cups
    {
        static void Main(string[] args)
        {
            int plannedNumberOfCups = int.Parse(Console.ReadLine());
            int availableWorkers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            int workingHours = workingDays * 8;

            double profit = availableWorkers * workingHours / 5 * 4.20;

            double expected = plannedNumberOfCups * 4.20;

            double difference = expected - profit;

            if(difference>0)
            {
                Console.WriteLine($"Losses: {difference.ToString("0.00")}");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(difference).ToString("0.00")} extra money");

            }
        }
    }
}