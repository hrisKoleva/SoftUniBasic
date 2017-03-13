using System;

namespace B_ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double tileSide = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double workerSalary = double.Parse(Console.ReadLine());

            double floorArea = floorLength * floorWidth;
            double tileArea = tileHeight * tileSide / 2;
            double tiles = floorArea / tileArea + 5;
            tiles = Math.Ceiling(tiles);


            double priceperAllTies = pricePerTile * tiles;

            double totalPrice = priceperAllTies + workerSalary;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"{(budget - totalPrice).ToString("0.00")} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {(totalPrice - budget).ToString("0.00")} lv more.");
            }
        }
    }
}