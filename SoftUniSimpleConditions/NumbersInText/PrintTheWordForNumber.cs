using System;
using System.Collections.Generic;

namespace NumbersInText
{
    class PrintTheWordForNumber
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> numbers = new Dictionary<int, string> { };

            numbers.Add(0, "zero");
            numbers.Add(1, "one");
            numbers.Add(2, "two");
            numbers.Add(3, "three");
            numbers.Add(4, "four");
            numbers.Add(5, "five");
            numbers.Add(6, "six");
            numbers.Add(7, "seven");
            numbers.Add(8, "eight");
            numbers.Add(9, "nine");

            int input = int.Parse(Console.ReadLine());
            if (numbers.ContainsKey(input))
            {
                Console.WriteLine(numbers[input]);
            }
            else
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
