using System;

namespace N_NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int nIndexInCurrentRow = n - i + 1;
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(n - Math.Abs(nIndexInCurrentRow - j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}