using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write("*");

                    }
                }
                else
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (j == 1 || j == n)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
