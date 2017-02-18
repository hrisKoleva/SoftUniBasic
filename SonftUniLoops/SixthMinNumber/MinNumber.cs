using System;

namespace SixthMinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            //Първо въведете едно число n (броят числа, които предстои да бъдат въведени).
            int n = int.Parse(Console.ReadLine());


            /* Alt
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if(input<min)
                {
                    min = input;
                }

            }*/

            //Въведете от конзолата първото число.
            int firstNumber = int.Parse(Console.ReadLine());

            //Сложете текущият Минимум min да е прочетеното число.
            int min = firstNumber;

            //В цикъл n-1 пъти прочетете по едно цяло число num.
            for (int i = 1; i <= n - 1; i++)
            {
                int nextNumber = int.Parse(Console.ReadLine());

                //Ако прочетеното число num е по-малко от текущият минимум мин,
                if (nextNumber < min)
                {
                    //запомнете num в max.
                    min = nextNumber;
                }
            }
            //Накрая в min трябва да се е запазило най - малкото число. Отпечатайте го.
            Console.WriteLine(min);
        }
    }
}