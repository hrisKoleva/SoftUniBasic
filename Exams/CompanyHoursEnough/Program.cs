using System;

namespace CompanyHoursEnough
{
    class Program
    {
        static void Main(string[] args)
        {
            int estimatedHours = int.Parse(Console.ReadLine());
            int availableDays = int.Parse(Console.ReadLine());
            int resources = int.Parse(Console.ReadLine());

            double normal = availableDays * 8;
            double overtime = availableDays * resources * 2;
            double education = normal * 10/100;
            double availableTotalHours = normal + overtime - education;

          
            if (estimatedHours <= availableTotalHours)
            {
                Console.WriteLine($"Yes!{Math.Floor(availableTotalHours-estimatedHours)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Ceiling(estimatedHours - availableTotalHours)} hours needed.");

            }
        }
    }
}
