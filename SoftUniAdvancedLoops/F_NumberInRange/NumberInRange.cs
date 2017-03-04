using System;

namespace F_NumberInRange
{
    class NumberInRange
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (number < 1 || number > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter a number in the range [1...100]: ");

                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: {0}", number);
        }
    }
}
