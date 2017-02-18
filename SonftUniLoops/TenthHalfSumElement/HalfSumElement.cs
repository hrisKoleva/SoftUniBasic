using System;

namespace TenthHalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                sum += numbers[i];
            }

            if (sum-max==max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff =  " + Math.Abs(max - (sum-max)));
            }
        }
    }
}