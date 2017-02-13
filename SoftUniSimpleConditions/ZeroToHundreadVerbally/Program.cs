using System;
using System.Collections.Generic;

namespace ZeroToHundreadVerbally
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> specialNumbers = new Dictionary<int, string>();
            specialNumbers.Add(0, "zero");
            specialNumbers.Add(1, "one");
            specialNumbers.Add(2, "two");
            specialNumbers.Add(3, "three");
            specialNumbers.Add(4, "four");
            specialNumbers.Add(5, "five");
            specialNumbers.Add(6, "six");
            specialNumbers.Add(7, "seven");
            specialNumbers.Add(8, "eight");
            specialNumbers.Add(9, "nine");
            specialNumbers.Add(10, "ten");
            specialNumbers.Add(11, "eleven");
            specialNumbers.Add(12, "twelve");
            specialNumbers.Add(13, "thirteen");
            specialNumbers.Add(15, "fifteen");
            specialNumbers.Add(18, "eighteen");
            specialNumbers.Add(20, "twenty");
            specialNumbers.Add(30, "thirty");
            specialNumbers.Add(40, "fourty");
            specialNumbers.Add(50, "fifty");
            specialNumbers.Add(100, "one hundred");

            int input = int.Parse(Console.ReadLine());
            int firstFigure;
            int secondFigure;
            string numberInEnglish;

            if (input >= 0 && input <= 100)
            {

                if (specialNumbers.ContainsKey(input))
                {
                    Console.WriteLine(specialNumbers[input]);
                }
                else if (input > 10)
                {
                    firstFigure = int.Parse(input.ToString().Substring(0, 1));
                    secondFigure = int.Parse(input.ToString().Substring(1, 1));

                    if (input < 20)
                    {
                        numberInEnglish = specialNumbers[secondFigure] + "teen";
                        Console.WriteLine(numberInEnglish);
                    }
                    else if (input < 100)
                    {
                        if (firstFigure >= 2 && firstFigure <= 5 && firstFigure != 4)
                        {
                            numberInEnglish = specialNumbers[firstFigure * 10] + " " + specialNumbers[secondFigure];
                        }
                        else if (firstFigure == 8)
                        {
                            numberInEnglish = "eighty " + specialNumbers[secondFigure];
                        }
                        else
                        {
                            numberInEnglish = specialNumbers[firstFigure] + "ty " + specialNumbers[secondFigure];
                        }

                        Console.WriteLine(numberInEnglish);
                    }
                }
            }
            else 
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}