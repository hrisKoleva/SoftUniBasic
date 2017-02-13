using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirteenPointInFigure
{
    class Program
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

            if ((x11 < x12 && y11 < y12) && (x21 < x22 && y21<y22))
            {
                if ((x < x12 && x > x11 && y < y12 && y > y11) && (x < x22 && x > x21 && y < y22 && y > y21))
                {
                    Console.WriteLine("inside");
                }
                else if(((((x == x11 || x == x12) && (y >= y11 && y <= y12)) || ((y == y11 || y == y12) && (x >= x11 && x <= x12)))) || ((((x == x21 || x == x22) && (y >= y21 && y <= y22)) || ((y == y21 || y == y22) && (x >= x21 && x <= x22)))))
                {
                    Console.WriteLine("border");

                }
                else
                    Console.WriteLine("outside");
            }
            else
            {
                return;
            }
        }
    }
}
