using System;

namespace F_RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', (n - i)));
                for (int j = 1; j <= i; j++)
                {
                    if (j != i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("*");

                    }
                }
                Console.WriteLine(new string(' ', (n - i)));
            }
            for (int i = n-1; i >= 1; i--)
            {
                Console.Write(new string(' ', (n - i)));
                for (int j = 1; j <= i; j++)
                {
                    if (j != i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("*");

                    }
                }
                Console.WriteLine(new string(' ', (n - i)));
            }
        }
    }
}