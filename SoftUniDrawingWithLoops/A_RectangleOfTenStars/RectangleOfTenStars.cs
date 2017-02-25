using System;

namespace A_RectangleOfTenStars
{
    class RectangleOfTenStars
    {
        static void Main(string[] args)
        {

            //вариант 1
            //for (int row = 1; row <= 10; row++)
            //{
            //    for (int column = 1; column <= 10; column++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //вариант 2
           // string rowOfStars = new string('*', 10);

            for (int row = 1; row <= 10; row++)
            {
                // Console.WriteLine(rowOfStars);

                //вариант 3
                //Console.WriteLine(new string('*', 10));

                //вариант 4
                //Console.Write(new string('*', 4));
                //Console.Write(new string('-', 2));
                //Console.Write(new string('*', 4));
                //Console.WriteLine();


                //вариант 5
                string stars = new string('*', 4);
                string dashes = new string('-', 2);

                //Console.WriteLine(stars + dashes + stars);


                //вариант 6
                Console.WriteLine($"{stars}{dashes}{stars}");

                //вариант 7
                Console.WriteLine("{0}{1}{0}", stars, dashes);

                //вариант 8 
                Console.WriteLine($@""); //също е възможно! и тогава хем можем да пишем изрази хем да ползваме escape символите!!!

               


            }
        }
    }
}
