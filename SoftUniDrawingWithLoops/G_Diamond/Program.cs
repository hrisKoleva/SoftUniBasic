using System;

namespace G_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int startStars = 2 - n % 2;

            // int topRows = (int)Math.Ceiling(n / 2.0);
            int topRows = (n + 1) / 2;
            int lowerRows = n - topRows;

            //topRow

            int startDashes = (n - startStars) / 2;
            Console.Write(new string('-', startDashes));
            Console.Write(new string('*', startStars));
            Console.WriteLine(new string('-', startDashes));

            //next rows
            for (int i = 0; i < topRows - 1; i++)
            {
                int innerDashes = startStars + i * 2;
                int outerDashes = (n - 2 - innerDashes) / 2;

                Console.Write(new string('-', outerDashes));
                Console.Write('*');
                Console.Write(new string('-', innerDashes));
                Console.Write('*');
                Console.WriteLine(new string('-', outerDashes));
            }

            //lowerRows
            for (int i = 0; i < lowerRows; i++)
            {
                int innerDashes = + i * 2;
                int outerDashes = (n - 2 - innerDashes) / 2;

                Console.Write(new string('-', outerDashes));
                Console.Write('*');
                Console.Write(new string('-', innerDashes));
                Console.Write('*');
                Console.WriteLine(new string('-', outerDashes));
            }
        }
    }
}
