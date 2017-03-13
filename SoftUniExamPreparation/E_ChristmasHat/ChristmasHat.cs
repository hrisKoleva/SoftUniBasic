using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ChristmasHat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startEndDots = 2 * n - 1;
            //rows = 4 * n + 1 
            //columns =  2 * n + 5 

            Console.Write(new string('.', startEndDots));
            Console.Write("/|\\");
            Console.Write(new string('.', startEndDots));
            Console.WriteLine();

            Console.Write(new string('.', startEndDots));
            Console.Write("\\|/");
            Console.Write(new string('.', startEndDots));
            Console.WriteLine();

            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine(
                    new string('.', startEndDots - i) +
                    "*" +
                    new string('-', i) +
                    "*" +
                     new string('-', i) +
                    "*" +
                    new string('.', startEndDots - i));

            }

            Console.WriteLine(new string('*', 4 * n + 1));
            Console.Write("*");

            for (int i = 0; i < 2*n; i++)
            {
                Console.Write(".*");
            }

            Console.WriteLine();
            Console.WriteLine(new string('*', 4 * n + 1));

        }
    }
}
