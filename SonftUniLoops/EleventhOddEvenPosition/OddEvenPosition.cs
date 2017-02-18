using System;
using System.Collections;

namespace EleventhOddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            double[] numbers = new double[n];

            for (int i = 0 ; i < n; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    oddSum += numbers[i];

                    if (numbers[i] <= oddMin)
                    {
                        oddMin = numbers[i];
                    }

                    if (numbers[i] >= oddMax)
                    {
                        oddMax = numbers[i];
                    }
                }
                else
                {
                    evenSum += numbers[i];

                    if (numbers[i] <= evenMin)
                    {
                        evenMin = numbers[i];
                    }

                    if (numbers[i] >= evenMax)
                    {
                       evenMax = numbers[i];
                    }
                }
            }
            Console.WriteLine("OddSum=" + oddSum);

            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin=" + oddMin);
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMax=" + oddMax);
            }

            Console.WriteLine("EvenSum=" + evenSum);

            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine("EvenMin=" + evenMin);
            }
            if (evenMax== double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax=" + evenMax);
            }
        }
    }
}
