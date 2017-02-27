using System;

namespace H_Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    Console.Write(new string('*', 2 * n));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', 2 * n));
                }
                else
                {
                    for (int j = 0; j < 5 * n; j++)
                    {
                        if (j == 0 || j == 2 * n - 1 || j == 3 * n || j == 5 * n - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            if ((j > 0 && j < 2 * n - 1) || (j > 3 * n && j < 5 * n - 1))
                            {
                                Console.Write("/");
                            }
                            else
                            {
                                if (n % 2 == 0 && (i == (n-1) / 2))
                                {
                                    Console.Write("|");
                                }
                                else if (n % 2 == 0 && i != (n-1) / 2)
                                {
                                    Console.Write(" ");
                                }
                                else if (n % 2 == 1 && i == n  / 2)
                                {
                                    Console.Write("|");
                                }
                                else if (n % 2 == 1 && i != n + 1 / 2)
                                {
                                    Console.Write(" ");
                                }

                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}