using System;

namespace ExcellentResult
{
    class CheckIfExcellent
    {
        static void Main(string[] args)
        {
            double rate = double.Parse(Console.ReadLine());
            if (rate >= 5.50)
            {
                Console.WriteLine("Excellent!");

            }
            else
            {
                Console.WriteLine("Not Excellent!");
            }
        }
    }
}