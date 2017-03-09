using System;

namespace N_NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                count++;

                if(count==row)
                {
                    Console.WriteLine();
                    count = 0;
                    row++;
                }
            }
            Console.WriteLine();
        }
    }
}