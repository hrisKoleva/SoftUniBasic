using System;

namespace J_CheckPrime
{
    class CheckIfIsPrime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            int i = 2;

            while (i <= n)
            {
                if (n % i != 0)
                {
                    i++;
                }
                else
                {
                    if (i == n)
                    {
                        isPrime = true;
                    }
                    else
                    {
                        isPrime = false;

                    }
                    break;
                }
            }

            if (n <= 0 || n == 1)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {

                if (isPrime)
                {
                    Console.WriteLine("Prime");

                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
            }
        }
    }
}
