using System;

namespace D_TriangleOfDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //вариант 1
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int column  = 1; column <= row; column++)
            //    {
            //        Console.Write("$ ");
            //    }
            //    Console.WriteLine();
            //}

            //вариант 2
            for (int row = 1; row <= n; row++)
            {
                string dollars = "";
                for (int column = 1; column <= row; column++)
                {
                    dollars += "$ ";
                }
                Console.WriteLine(dollars.TrimEnd());
            }
        }
    }
}
