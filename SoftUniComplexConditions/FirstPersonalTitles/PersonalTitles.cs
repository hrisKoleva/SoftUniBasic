﻿using System;

namespace FirstPersonalTitles
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            switch (sex)
            {
                case "m":
                    {
                        if (age >= 16)
                        {
                            Console.WriteLine("Mr.");
                        }
                        else
                            Console.WriteLine("Master");
                    }
                break;
                case "f":
                    {
                        if (age >= 16)
                        {
                            Console.WriteLine("Ms.");
                        }
                        else
                            Console.WriteLine("Miss");
                    }
                break;
                default: return;
            }
        }
    }
}