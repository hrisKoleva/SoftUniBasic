﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateSomeConbinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] words = new string[n];

            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{words[j]}, ");

                    for (int m = 0; m < n; m++)
                    {
                        Console.WriteLine($"{words[j]}, {words[m]}");

                    }

                }
            }
        }
    }
}
