using System;

namespace I_House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (int i = 1; i <= n/2; i++)
                {
                    Console.Write(new string('-', Math.Abs(i - n/2)));
                    Console.Write(new string('*', 2 * i));
                    Console.WriteLine(new string('-', Math.Abs(i - n/2)));
                }
                for (int j = 1; j <= n/2; j++)
                {
                    Console.Write(new string('|', 1));
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine(new string('|', 1));
                }
            }
            else
            {
                for (int i = 1; i <= (n+1)/2; i++)
                {
                    Console.Write(new string('-', Math.Abs(i - (n + 1) / 2)));
                    Console.Write(new string('*', 2 * i - 1));
                    Console.WriteLine(new string('-', Math.Abs(i - (n + 1) / 2)));
                }
                for (int j = 1; j < ((n + 1) / 2); j++)
                {
                    Console.Write(new string('|', 1));
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine(new string('|', 1));
                }
            }
        }
    }
}