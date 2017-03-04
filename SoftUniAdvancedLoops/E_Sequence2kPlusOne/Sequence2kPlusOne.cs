using System;

namespace E_Sequence2kPlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            /* Loops EXPLAINED !!!!!!!
             * 
            int counter = 0; - initialize counter
            for (;;)
            {
                Console.WriteLine(counter); - do something
                if(counter >10) - check for exit condition
                {
                    break;
                }

               // Console.WriteLine(counter); - do something
                counter++; - increment the counter
                }
                */

            // initialize counter
            int number = 1;
            while (number <= n)//check for exit condition
            {
                //body
                Console.WriteLine(number);

                number = number * 2 + 1;
                //increment counter
            }
        }
    }
}
