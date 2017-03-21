using System;

namespace EExamTask
{
    class SoftUniLogo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rows = 4 * n - 2;
            int columns = 12 * n - 5;

            int upperRows = rows / 2;
            int lowerRows = rows - upperRows - n - 3;

            for (int i = 0; i <= upperRows; i++)
            {
                Console.Write(new string('.', (12 * n - 5) / 2 - i * 3));
                Console.Write(new string('#', ((12 * n - 5) - 2 * ((12 * n - 5) / 2 - i * 3))));
                Console.Write(new string('.', (12 * n - 5) / 2 - i * 3));
                Console.WriteLine();
            }

            int dots = 0;
            int hashtags = 0;

            for (int i = 0; i < n - 2; i++)
            {
                dots = 3 + 3 * i;
                hashtags = columns - 2 * dots;

                Console.Write("|");
                Console.Write(new string('.', dots - 1));
                Console.Write(new string('#', hashtags));
                Console.Write(new string('.', dots));
                Console.WriteLine();
            }

            for (int i = 0; i <= n - 2; i++)
            {
                Console.Write("|");
                Console.Write(new string('.', (columns-(6*n+1))/2-1));
                Console.Write(new string('#', 6*n+1));
                Console.Write(new string('.', (columns - (6 * n + 1)) / 2));
                Console.WriteLine();
            }

            Console.Write("@");
            Console.Write(new string('.', (columns - (6 * n + 1)) / 2 - 1));
            Console.Write(new string('#', 6 * n + 1));
            Console.Write(new string('.', (columns - (6 * n + 1)) / 2));
            Console.WriteLine();
        }
    }
}

