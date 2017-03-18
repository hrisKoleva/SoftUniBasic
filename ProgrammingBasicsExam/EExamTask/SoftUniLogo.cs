using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int lowerRows = rows - upperRows;

            /*
             * ...............#...............
               ............#######............
               .........#############.........
               ......###################......
               ...#########################...
               ###############################*/

            for (int i = 0; i <= upperRows; i++)
            {
                Console.Write(new string('.', (12 * n - 5) / 2 - i * 3));
                Console.Write(new string('#', ((12*n-5) - 2* ((12 * n - 5) / 2 - i * 3))));
                Console.Write(new string('.', (12 * n - 5) / 2 - i * 3));
                Console.WriteLine();
            }

            /*
               |..#########################...

               |.....###################......
               |.....###################......
               @.....###################......	
           */

            for (int i = 0; i < n-2; i++)
            {
                Console.Write("|");
                Console.Write(new string('.', (n - 1) + i * 3));

            }


            for (int i = 0; i < lowerRows; i++)
            {
                Console.Write("|");

            }


        }
    }
}
