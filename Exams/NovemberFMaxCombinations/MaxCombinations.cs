using System;

namespace NovemberFMaxCombinations
{
    class MaxCombinations
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());

            int maxCombinationsToPrint = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                for (int j = firstNumber; j <= lastNumber; j++)
                {
                    if (count < maxCombinationsToPrint)
                    {
                        Console.Write($"<{i}-{j}>");
                        count++;
                    }
                }
            }
        }
    }
}