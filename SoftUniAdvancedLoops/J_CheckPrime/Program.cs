using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    break;
                }
                i++;

            }



        }
    }
}
