using System;

namespace SeventhLeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstHalfNumbers = new int[n];
            int leftSum = 0;

            int[] secondHalfNumbers = new int[n];
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                firstHalfNumbers[i] = int.Parse(Console.ReadLine());
                leftSum += firstHalfNumbers[i];
            }

            for (int i = 0; i < n; i++)
            {
                secondHalfNumbers[i] = int.Parse(Console.ReadLine());
                rightSum += secondHalfNumbers[i];
            }

            if (leftSum==rightSum)
            {
                Console.WriteLine("Yes, sum = " + rightSum);
            }
            else
            {
                Console.WriteLine("No, diff =  " + Math.Abs(leftSum - rightSum));
            }

        }
    }
}