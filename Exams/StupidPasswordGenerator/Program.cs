using System;

namespace StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int m = 1; m <= l; m++)
                    {
                        for (int p = 1; p <= l; p++)
                        {
                            for (int h = Math.Max(i, j) + 1; h <= n; h++)
                            {
                                Console.Write("{0}", i);
                                Console.Write("{0}", j);
                                Console.Write(Convert.ToChar(m + 96).ToString());
                                Console.Write(Convert.ToChar(p + 96).ToString());
                                Console.Write("{0}", h);
                                Console.Write(" ");
                            }
                        }

                    }
                }
            }
        }
    }
}
