using System;

namespace TilesRepairment
{
    class Program
    {
        static void Main(string[] args)
        {
            double square = double.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLength = double.Parse(Console.ReadLine());

            double benchWidth = double.Parse(Console.ReadLine());
            double benchLength = double.Parse(Console.ReadLine());

            double tiles = (square * square - benchLength * benchWidth) / (tileLength * tileWidth);

            double time = tiles * 0.2;

            Console.WriteLine(tiles);
            Console.WriteLine(time);
        }
    }
}
