using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            if (n >= 1 && n <= 1000)
            {
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                foreach (int number in numbers)
                {
                    if (number < 200)
                    {
                        p1++;
                        
                    }
                    else if (number >= 200 && number <= 399)
                    {
                        p2++;
                    }
                    else if (number >= 400 && number <= 599)
                    {
                        p3++;
                    }
                    else if(number >=600 && number <=799)
                    {
                        p4++;
                    }
                    else if(number>=800)
                    {
                        p5++;
                    }

                }
                Console.WriteLine("{0:0.00}%", Math.Round(p1 * 100 / n, 2));
                Console.WriteLine("{0:0.00}%", Math.Round(p2 * 100 / n, 2));
                Console.WriteLine("{0:0.00}%", Math.Round(p3 * 100 / n, 2));
                Console.WriteLine("{0:0.00}%", Math.Round(p4 * 100 / n, 2));
                Console.WriteLine("{0:0.00}%", Math.Round(p5 * 100 / n, 2));
            }
            else
                return;
        }
    }
}