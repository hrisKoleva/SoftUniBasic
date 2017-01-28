using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManySeats
{
    class Program
    {
        static void Main(string[] args)
        {
            double seatWidth = 120.00;
            double seatHeight = 70.00;
            double corridorWidth = 100.00;
            double corridorHeight;

            double roomWidth = double.Parse(Console.ReadLine());
            double roomHeight = double.Parse(Console.ReadLine());

            corridorHeight = roomHeight;
            int lostSeats = 3;

            double rows = Math.Floor((roomWidth*100-corridorWidth) / seatWidth);
            double columns = Math.Floor(roomHeight*100/seatHeight);

            double seats = (rows * columns) - lostSeats;
            
            if (roomHeight >= roomWidth || roomHeight <= 3 || roomWidth >= 100)
            {
                Console.WriteLine("Invalid room size");
            }
            else
            {
                Console.WriteLine(Math.Round(seats));
            }
        }
    }
}
