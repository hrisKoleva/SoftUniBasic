using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Fortress
{
    class Program
    {
        static void Main(string[] args)
        {
            //ширина 2 * n колони и  височина n реда
            /* 8
             *  012345
                /^^^^\____ /^^^^\
                |               |
                |               |
                |               |
                |               |
                |               |
                |     ____      |
                \____/    \____/
            
             */

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                if (n >= 5)
                {
                    if (n % 2 == 1)
                    {
                        if (i == 0)
                        {
                            Console.Write('/');
                            Console.Write(new string('^', n / 2));
                            Console.Write('\\');
                            Console.Write(new string('_', n - 3));
                            Console.Write('/');
                            Console.Write(new string('^', n / 2));
                            Console.WriteLine('\\');
                        }
                        else if (i == n - 1)
                        {
                            Console.Write('\\');
                            Console.Write(new string('_', n / 2));
                            Console.Write('/');
                            Console.Write(new string(' ', n - 3));
                            Console.Write('\\');
                            Console.Write(new string('_', n / 2));
                            Console.WriteLine('/');
                        }
                        else if (i == n - 2)
                        {
                            Console.Write("| ");
                            Console.Write(new string(' ', n / 2));
                            Console.Write(new string('_', n - 3));
                            Console.Write(new string(' ', n / 2));
                            Console.WriteLine(" |");
                        }
                        else
                        {
                            Console.Write("|");
                            Console.Write(new string(' ', 2 * n - 2));
                            Console.WriteLine("|");
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            Console.Write('/');
                            Console.Write(new string('^', n / 2));
                            Console.Write('\\');
                            Console.Write(new string('_', n - 4));
                            Console.Write('/');
                            Console.Write(new string('^', n / 2));
                            Console.WriteLine('\\');
                        }
                        else if (i == n - 1)
                        {
                            Console.Write('\\');
                            Console.Write(new string('_', n / 2));
                            Console.Write('/');
                            Console.Write(new string(' ', n - 4));
                            Console.Write('\\');
                            Console.Write(new string('_', n / 2));
                            Console.WriteLine('/');
                        }
                        else if (i == n - 2)
                        {
                            Console.Write("| ");
                            Console.Write(new string(' ', n / 2));
                            Console.Write(new string('_', n - 4));
                            Console.Write(new string(' ', n / 2));
                            Console.WriteLine(" |");
                        }
                        else
                        {
                            Console.Write("|");
                            Console.Write(new string(' ', 2 * n - 2));
                            Console.WriteLine("|");
                        }
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        Console.Write('/');
                        Console.Write(new string('^', n / 2));
                        Console.Write('\\');
                        // Console.Write(new string('_', n / 2));
                        Console.Write('/');
                        Console.Write(new string('^', n / 2));
                        Console.WriteLine('\\');
                    }
                    else if (i == n - 1)
                    {
                        Console.Write('\\');
                        Console.Write(new string('_', n / 2));
                        Console.Write('/');
                        // Console.Write(new string(' ', n / 2));
                        Console.Write('\\');
                        Console.Write(new string('_', n / 2));
                        Console.WriteLine('/');
                    }
                    else if (i == n - 2)
                    {
                        Console.Write("| ");
                        Console.Write(new string(' ', n / 2));
                        //Console.Write(new string('_', n / 2));
                        Console.Write(new string(' ', n / 2));
                        Console.WriteLine(" |");
                    }
                    else
                    {
                        Console.Write("|");
                        Console.Write(new string(' ', 2 * n - 2));
                        Console.WriteLine("|");
                    }
                }
            }

        }
    }
}
