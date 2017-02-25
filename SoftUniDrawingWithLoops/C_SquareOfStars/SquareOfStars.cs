using System;

namespace C_SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //вариант 1
            //for (int row = 0; row < n; row++)
            //{
            //    Console.Write("*");
            //    for (int column = 0; column < n-1; column++)
            //    {
            //        Console.Write(" *");

            //    }
            //    Console.WriteLine();
            //}

            //вариант 2
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n - 1; column++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine("*");
            }

        }
    }
}
