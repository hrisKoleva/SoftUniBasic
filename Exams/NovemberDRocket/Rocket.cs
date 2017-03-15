using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberDRocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            /*ширина – 3 * N колони.*/

            /*
             *  ...../\.....
                ..../  \....
                .../    \...
                ../      \..

                ..********..
                
                ..|\\\\\\|..
                ..|\\\\\\|..
                ..|\\\\\\|..
                ..|\\\\\\|..
                ..|\\\\\\|..
                ..|\\\\\\|..
                ..|\\\\\\|..
                ..|\\\\\\|..
                
                ../******\..
                ./********\.
             */

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', (3*n-2)/2 - i));
                Console.Write("/");
                Console.Write(new string(' ', 2*i));
                Console.Write("\\");
                Console.Write(new string('.', (3*n-2)/2 - i));
                Console.WriteLine();

            }

            Console.Write(new string('.', n / 2));
            Console.Write(new string('*', 2 * n));
            Console.Write(new string('.', n / 2));
            Console.WriteLine();

            for (int i = 0; i < 2*n; i++)
            {
                Console.Write(new string('.', n / 2));
                Console.Write("|");
                Console.Write(new string('\\', (2 * n - 2)));
                Console.Write("|");
                Console.Write(new string('.', n / 2));
                Console.WriteLine();
            }


            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('.',n/2 - i));
                Console.Write("/");
                Console.Write(new string('*', 2*n-2+2*i));
                Console.Write("\\");
                Console.Write(new string('.', n/2 - i));
                Console.WriteLine();
            }

        }
    }
}
