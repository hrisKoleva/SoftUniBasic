using System;

namespace D_EvenPowersOfTwo
{
    class EvenPowersOfTwo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i+=2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
