using System;

namespace DExamTask
{
    class GameOfIntervals
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double currentScore = 0;
            int countInFirstInterval = 0;
            int countInSecondInterval = 0;
            int countInThirdInterval = 0;
            int countInForthInterval = 0;
            int countInFifthInterval = 0;
            int countOfInvalid = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 0 && number <= 9)
                {
                    countInFirstInterval++;
                    currentScore += 0.2 * number;
                }
                else if (number >= 10 && number <= 19)
                {
                    countInSecondInterval++;
                    currentScore += 0.3 * number;


                }
                else if (number >= 20 && number <= 29)
                {
                    countInThirdInterval++;
                    currentScore += 0.4 * number;

                }
                else if (number >= 30 && number <= 39)
                {
                    countInForthInterval++;
                    currentScore += 50;
                }
                else if (number >= 40 && number <= 50)
                {
                    countInFifthInterval++;
                    currentScore += 100;

                }
                else
                {
                    countOfInvalid++;
                    currentScore = currentScore / 2;
                }
            }


            double p1 = countInFirstInterval * 100 / (double)n;
            double p2 = countInSecondInterval * 100 / (double)n;
            double p3 = countInThirdInterval * 100 / (double)n;
            double p4 = countInForthInterval * 100 / (double)n;
            double p5 = countInFifthInterval * 100 / (double)n;
            double p6 = countOfInvalid * 100 / (double)n;

            Console.WriteLine($"{currentScore.ToString("0.00")}");
            Console.WriteLine($"From 0 to 9: {p1.ToString("0.00")}%");
            Console.WriteLine($"From 10 to 19: {p2.ToString("0.00")}%");
            Console.WriteLine($"From 20 to 29: {p3.ToString("0.00")}%");
            Console.WriteLine($"From 30 to 39: {p4.ToString("0.00")}%");
            Console.WriteLine($"From 40 to 50: {p5.ToString("0.00")}%");
            Console.WriteLine($"Invalid numbers: {p6.ToString("0.00")}%");

        }
    }
}