using System;

namespace G_GreatestCommonDivisorGCD
{
    class GreatestCommonDivisorGCD
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (a%b !=0)
            {
                var x = a % b;
                a = b;
                b = x;
              
            }
            Console.WriteLine(b);
        }
    }
}
