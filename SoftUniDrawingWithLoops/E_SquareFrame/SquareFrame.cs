using System;

namespace E_SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //вариант 2
            for (int i = 0; i < n; i++)
            {
                char symbol = '|';

                if (i == 0 || i == n - 1)
                {
                    symbol = '+';
                }
                Console.Write($"{symbol}");
                for (int m = 0; m < n - 2; m++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine($"{symbol}");

            }



        //вариант 1
            //  //  PrintPlusSigns(n);


            //    for (int j = 0; j < n - 2; j++)
            //    {
            //        Console.Write("| ");
            //        for (int m = 0; m < n - 2; m++)
            //        {
            //            Console.Write("- ");
            //        }
            //        Console.WriteLine('|');
            //    }

            //    PrintPlusSigns(n);


            //    //method

            //    //string inputStr = " *";
            //    //ReturnInoPutStringNimes(5, inputStr);
            //    //Console.WriteLine();
            //}

            //private static void PrintPlusSigns(int n)
            //{
            //    Console.Write("+ ");
            //    for (int i = 0; i < n - 2; i++)
            //    {
            //        Console.Write("- ");
            //    }
            //    Console.Write("+");
            //    Console.WriteLine();
            //}

            ////method
            ////private static void ReturnInoPutStringNimes(int n, string inputStr)
            ////{
            ////    string returnStr = "";
            ////    for (int i = 0; i < n; i++)
            ////    {
            ////        returnStr += inputStr;
            ////    }
            ////    Console.Write(returnStr);

        }
    }
}