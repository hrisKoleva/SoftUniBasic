using System;

namespace BExamTask
{
    class WorkHours
    {
        static void Main(string[] args)
        {

            /*СТЕНИ зелената боя е 1 литър за 3 м2*/
            /*червената – 1 литър за 5 м2*/

            double sideWithA = double.Parse(Console.ReadLine());
            double heightB = double.Parse(Console.ReadLine());

            double frontLowerRectangle = sideWithA / 2 * sideWithA / 2.00;
            double frontUpperTriangle = (sideWithA / 2 * (heightB - sideWithA / 2)) / 2.00;
            double frontDoor = sideWithA / 5 * sideWithA / 5;

            double frontside = frontLowerRectangle - frontDoor + frontUpperTriangle;

            double backSide = frontUpperTriangle + frontLowerRectangle;

            double sides = 2 * (sideWithA * sideWithA / 2);

            double roof = 2 * (sideWithA * sideWithA / 2);

            double walls = frontside + backSide + sides;

            double greenPaintAmout = walls / 3;
            double redPaintAmount = roof / 5;


            Console.WriteLine(greenPaintAmout.ToString("0.00"));
            Console.WriteLine(redPaintAmount.ToString("0.00"));

        }
    }
}