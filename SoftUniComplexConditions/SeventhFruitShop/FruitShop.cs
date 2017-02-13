using System;
using System.Collections.Generic;

namespace SeventhFruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> workingDays = new Dictionary<string, double>();
            Dictionary<string, double> weekend = new Dictionary<string, double>();
            workingDays.Add("banana", 2.50);
            workingDays.Add("apple", 1.20);
            workingDays.Add("orange", 0.85);
            workingDays.Add("grapefruit", 1.45);
            workingDays.Add("kiwi", 2.70);
            workingDays.Add("pineapple", 5.50);
            workingDays.Add("grapes",3.85);
            weekend.Add("banana", 2.70);
            weekend.Add("apple", 1.25);
            weekend.Add("orange", 0.90);
            weekend.Add("grapefruit", 1.60);
            weekend.Add("kiwi", 3.00);
            weekend.Add("pineapple", 5.60);
            weekend.Add("grapes", 4.20);

            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double amount = double.Parse(Console.ReadLine());
            double result;
            
           if(day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (workingDays.ContainsKey(fruit))
                {
                    result = workingDays[fruit] * amount;
                    Console.WriteLine("{0:0.00}", result);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
           else if(day == "saturday" || day == "sunday")
            {
                if (weekend.ContainsKey(fruit))
                {
                    result = weekend[fruit] * amount;
                    Console.WriteLine("{0:0.00}", result);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        
        }
    }
}