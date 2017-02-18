using System;

namespace FifthMaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            //Първо въведете едно число n (броят числа, които предстои да бъдат въведени).
            int n = int.Parse(Console.ReadLine());

            //Въведете от конзолата първото число.
            int firstNumber = int.Parse(Console.ReadLine());

            //Сложете текущият максимум max да е прочетеното число.
            int max = firstNumber;

            //В цикъл n-1 пъти прочетете по едно цяло число num.
            for (int i = 1; i <=n-1; i++)
            {
                int nextNumber = int.Parse(Console.ReadLine());

                //Ако прочетеното число num е по-голямо от текущият максимум max,
                if (nextNumber>max)
                {
                    //запомнете num в max.
                    max = nextNumber;
                }
            }
           //Накрая в max трябва да се е запазило най - голямото число.Отпечатайте го.
            Console.WriteLine(max);
        }
    }
}