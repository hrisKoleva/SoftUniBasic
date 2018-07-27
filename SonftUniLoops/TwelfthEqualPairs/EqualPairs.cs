using System;

namespace TwelfthEqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[2 * n];
            int[] sumOfPairs = new int[n];
            int tempSum = 0;
            int difference = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    numbers[j] = int.Parse(Console.ReadLine());
                    sumOfPairs[i] += numbers[j];
                }
            }

            tempSum = sumOfPairs[0];

            for (int i = 1; i < n; i++)
            {
                if (sumOfPairs[i] >= tempSum)
                {
                    difference = sumOfPairs[i] - sumOfPairs[i - 1];
                    tempSum = sumOfPairs[i];
                }
                else if (sumOfPairs[i] < tempSum)
                {
                    tempSum = sumOfPairs[i - 1];
                    difference = tempSum - sumOfPairs[i];
                }

            }

            if (difference != 0)
            {
                Console.WriteLine($"No, maxdiff={Math.Abs(difference)}");
            }
            else
            {
                Console.WriteLine($"Yes, value={tempSum}");
            }

        }
    }
}

