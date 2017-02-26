using System;

namespace J_Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //нечетно n
            if (n % 2 == 1)
            {
                for (int i = 1; i <= (n + 1) / 2; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if ((j == ((n + 1) / 2) - (i - 1)) || j == ((n + 1) / 2) + (i - 1))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");

                        }
                    }
                    Console.WriteLine();
                }
                for (int i = (n + 1) / 2 - 1; i >= 1; i--)
                {
                    for (int j = 1; j <= n; j++)
                    {

                        if ((j == ((n + 1) / 2) - (i - 1)) || j == ((n + 1) / 2) + (i - 1))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");

                        }
                    }
                    Console.WriteLine();
                }
            }
            else //четно
            {
                for (int i = 1; i <= n / 2; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (j == (n/2 - (i - 1)) || j == ((n/2+1) + (i - 1)))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");

                        }
                    }
                    Console.WriteLine();
                }
                for (int i = (n/2)-1; i >= 1; i--)
                {
                    for (int j = 1; j <= n; j++)
                    {

                        if (j == (n/2 - (i - 1)) || j == ((n/2+1) + (i - 1)))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");

                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}