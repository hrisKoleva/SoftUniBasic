using System;

namespace I_SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            //solution 1
            /*
            int number = int.Parse(Console.ReadLine());
            int digits;
            int sum = 0;

            for (int i = 0; i < number.ToString().Length; i++)
            {
               digits = int.Parse(number.ToString().Substring(i,1));
               sum += digits;
            }
            Console.WriteLine(sum); 
            */

            //solution 2
            //int number = int.Parse(Console.ReadLine());
            //int sumOfDigits = 0;

            //while (number > 0)
            //{
            //    int remainder = number % 10;
            //    sumOfDigits += remainder;
            //    number = number / 10;
            //}
            //Console.WriteLine(sumOfDigits);


            //solution 3
            string input = Console.ReadLine();
            int sum = 0;
            int inputLength = input.Length;
            int counter = inputLength;

            while (counter >0)
            {
                sum += int.Parse(input[counter - 1].ToString());
                counter--;
            }
            Console.WriteLine(sum);
        }
    }
}
