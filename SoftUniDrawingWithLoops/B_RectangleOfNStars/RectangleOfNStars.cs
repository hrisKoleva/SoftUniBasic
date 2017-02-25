using System;

namespace B_RectangleOfNStars
{
    class RectangleOfNStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            ////вариант 2 - 
            //for (int i = -n; i <= n; i++)
            //{
            //    Console.WriteLine(new string('*', Math.Abs(i)));
            //}
            /*
            *****
            ****
            ***
            **
            *

            *
            **
            ***
            ****
            *****
            */

            //вариант 3
            //           for (int i = -n; i <= n; i++)
            //           {
            //               Console.WriteLine(new string('*', n-Math.Abs(i)));
            //           }

            /*


*
**
***
****
*****
****
***
**
*
  */
        }
    }
}
