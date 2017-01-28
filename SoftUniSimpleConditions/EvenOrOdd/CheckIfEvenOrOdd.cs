using System;

namespace EvenOrOdd
{
    class CheckIfEvenOrOdd
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");

            }
            else if(number % 2 == 1)
            {
                Console.WriteLine("Odd");
            }
        }
    }
}