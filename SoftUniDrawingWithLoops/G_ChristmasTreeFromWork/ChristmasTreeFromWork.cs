using System;

namespace G_ChristmasTreeFromWork
{
    class ChristmasTreeFromWork
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n+1; i++)
            {
                Console.Write(new string(' ', n - i));

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                  
                }
               
                Console.Write(" | ");

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");

                }

                Console.WriteLine();
            }
        }
    }
}
