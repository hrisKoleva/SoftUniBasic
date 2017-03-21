using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FExamTask
{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());

            int magicNumber = int.Parse(Console.ReadLine());

            bool hasMagic = false;
            int count = 0;
            int magicCount = 0;
            int first = 0;
            int sec = 0;

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                for (int j = firstNumber; j <= lastNumber; j++)
                {
                    count++;

                    if ((i + j) == magicNumber)
                    {
                        hasMagic = true;
                        magicCount = count;
                        first = i;
                        sec = j;

                        i = lastNumber;
                        j = lastNumber;
                    }
                }
            }

            if (hasMagic==true)
            {
                Console.WriteLine($"Combination N:{magicCount} ({first} + {sec} = {magicNumber})");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}
