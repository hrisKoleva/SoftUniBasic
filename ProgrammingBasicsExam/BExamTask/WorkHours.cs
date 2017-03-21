using System;

namespace BExamTask
{
    class WorkHours
    {
        static void Main(string[] args)
        {

            int expectedHours = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            int hoursLeft = 0;
            int penalties = 0;
            int overtime = 0;


            int actualHours = numberOfDays * numberOfWorkers*8;
            if (expectedHours > actualHours)
            {
                overtime =  expectedHours - actualHours;

                penalties = overtime * numberOfDays;

                Console.WriteLine($"{overtime} overtime");
                Console.WriteLine($"Penalties: {penalties}");
            }
            else
            {
                hoursLeft = actualHours - expectedHours;
                Console.WriteLine($"{hoursLeft} hours left");

            }
        }
    }
}