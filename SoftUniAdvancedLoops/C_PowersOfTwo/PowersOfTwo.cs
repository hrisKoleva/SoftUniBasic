using System;

namespace C_PowersOfTwo
{
    class PowersOfTwo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }

            //solution 2
            //int result = 1;
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine(result);
            //    result = result * 2;
            //}
        }
    }
}
