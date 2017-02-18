using System;

namespace EighthOddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if(i%2==0)
                {
                    evenSum += numbers[i];
                }
                else
                {
                    oddSum += numbers[i];
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff =  " + Math.Abs(oddSum - evenSum));
            }
        }
    }
}