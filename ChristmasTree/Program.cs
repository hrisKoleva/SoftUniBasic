using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= 2*n+1; j++)
                {
                    if (j==n+1)
                    {
                        Console.Write("|");

                    }
                   if (j>=n+1-i && j<=n+1-i)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
