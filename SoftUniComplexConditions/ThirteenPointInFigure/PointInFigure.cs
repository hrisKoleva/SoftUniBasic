using System;

namespace ThirteenPointInFigure
{
    class PointInFigure
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());

            double x11 = 0;
            double y11 = 0;
            double x12 = 3 * h;
            double y12 = h;
            
            double x21 = h;
            double y21 = 0;
            double x22 = 2 * h;
            double y22 = 4 * h;

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isOnXFirst = (x == x11 || x == x12) && (y >= y11 && y <= y12);
            bool isOnYFirst = (y == y11 || y == y12) && (x >= x11 && x <= x12);
            bool isOnXSecond = (x == x21 || x == x22) && (y >= y21 && y <= y22);
            bool isOnYSecond = (y == y21 || y == y22) && (x >= x21 && x <= x22);

            bool isInsideFirst = (x < x12 && x > x11) && (y < y12 && y > y11);
            bool isInsideSecond = (x < x22 && x > x21) && (y < y22 && y > y21);

            if(isInsideFirst || isInsideSecond)
            {
                Console.WriteLine("inside");
            }
            else if((isOnXFirst || isOnYFirst) || (isOnXSecond || isOnYSecond))
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
           
        }
    }
}