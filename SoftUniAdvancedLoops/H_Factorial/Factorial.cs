using System;

namespace H_Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            //solution 1
            //int n = int.Parse(Console.ReadLine());
            //int result = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    result = result * i;
            //}
            //Console.WriteLine(result);

            //solution 2
            int n = int.Parse(Console.ReadLine());
            int product = 1;
            int counter = 1;
            do
            {
                product = product * counter;
                counter++;
            }
            while (counter<=n);
            Console.WriteLine(product);
        }
    }
}