using System;

namespace F_RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = -n; i < n; i++)
            {
                for (int j = 0; j < n - Math.Abs(i); j++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write("  *");
                    }
                    else
                    {
                        Console.Write(" *");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
