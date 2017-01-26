using System;

namespace GreaterNumber
{
    class PrintGreaterNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a>=b)
            {
                Console.WriteLine("Greater number: {0}", a);
            }
            else
            {
                Console.WriteLine("Greater number: {0}", b);
            }
        }
    }
}
