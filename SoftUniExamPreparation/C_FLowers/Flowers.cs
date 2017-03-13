using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_FLowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            //chrysanthemum

            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            bool isHoliday = Console.ReadLine() == "Y" ? true : false;

            double totalPrice = 0;

            if (season.Equals("Spring") || season.Equals("Summer"))
            {
                totalPrice = chrysanthemums * 2.00 + roses * 4.10 + tulips * 2.50;
            }
            else if (season.Equals("Winter") || season.Equals("Autumn"))
            {
                totalPrice = chrysanthemums * 3.75 + roses * 4.50 + tulips * 4.15;
            }

            if (isHoliday)
            {
                totalPrice = totalPrice * 1.15;
            }
            if (tulips > 7 && season.Equals("Spring"))
            {
                totalPrice = totalPrice * 0.95;
            }
            if (roses >= 10 && season.Equals("Winter"))
            {
                totalPrice = totalPrice * 0.9;
            }
            if ((roses + tulips + chrysanthemums) > 20)
            {
                totalPrice = totalPrice * 0.8;
            }

            totalPrice = totalPrice + 2;
            Console.WriteLine(totalPrice.ToString("0.00"));

        }
    }
}
