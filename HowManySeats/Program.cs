using System;

namespace HowManySeats
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double newLength = length * 100;
            double newWidth = width * 100 - 100;

            double seatLength = 120;
            double seatWidth = 70;

            double rows = Math.Floor(newLength / seatLength);
            double columns = Math.Floor(newWidth / seatWidth);

            double seats = rows * columns - 3;
            Console.WriteLine(seats);
        }
    }
}
