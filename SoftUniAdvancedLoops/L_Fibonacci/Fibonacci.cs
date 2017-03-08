using System;

namespace L_Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstNumber =1;
            int secondNumber=1;
            int nextNumber = 1;

            for (int i = 0; i <= n; i++)
            {
                if(i==0 || i==1)
                {
                    firstNumber = 1;
                    secondNumber = 1;
                }
                else
                {
                    nextNumber = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
            }
            Console.WriteLine(nextNumber);
        }
    }
}
