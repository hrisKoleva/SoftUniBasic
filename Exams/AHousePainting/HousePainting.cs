using System;

namespace AHousePainting
{
    class HousePainting
    {
        static void Main(string[] args)
        {
            double xHouseHight = double.Parse(Console.ReadLine());
            double yHouseLength = double.Parse(Console.ReadLine());
            double hRoofHeight = double.Parse(Console.ReadLine());

            double greenAreaWallsWithoutDoorAndWindows = (xHouseHight*xHouseHight + xHouseHight*xHouseHight + xHouseHight*yHouseLength + xHouseHight*yHouseLength - 2.4 - 2*1.5*1.5);
            double redAreaRoof = (xHouseHight * hRoofHeight + 2 * xHouseHight * yHouseLength);

            Console.WriteLine($"{(greenAreaWallsWithoutDoorAndWindows/3.4).ToString("0.00")}");
            Console.WriteLine($"{(redAreaRoof/4.3).ToString("0.00")}");
        }
    }
}