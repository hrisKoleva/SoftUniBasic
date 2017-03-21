using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                
                Console.WriteLine($"{i} % 2 =  {i % 2}");
                Console.WriteLine($"{i} / 2 =  {i / 2}");
                Console.WriteLine($"{i} % 3 =  {i % 3}");
                Console.WriteLine($"{i} / 3 =  {i / 3}");




            }

            Console.ReadLine();
        }
    }
}
