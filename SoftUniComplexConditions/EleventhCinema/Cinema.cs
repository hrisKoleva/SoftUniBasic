using System;

namespace EleventhCinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string cinemaType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double price;

            switch (cinemaType)
            {
                case "Premiere": price = 12.00; break;
                case "Normal": price = 7.50; break;
                case "Discount": price = 5.00; break;
                default: return;
            }

            Console.WriteLine("{0:0.00} leva", rows * columns * price);
        }
    }
}