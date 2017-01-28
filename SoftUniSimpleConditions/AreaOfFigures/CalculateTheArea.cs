using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class CalculateTheArea
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double firstSide;
            double secondSide;
            double area;

            if(figure.Equals("square"))
            {
                firstSide = double.Parse(Console.ReadLine());
                area = Math.Pow(firstSide, 2);
                Console.WriteLine(Math.Round(area, 3));
            }
            else
            {
                return;
            }

            if (figure.Equals("rectangle"))
            {
                firstSide = double.Parse(Console.ReadLine());
                secondSide = double.Parse(Console.ReadLine());
                area = firstSide * secondSide;
                Console.WriteLine(Math.Round(area, 3));
            }

            if (figure.Equals("circle"))
            {
                firstSide = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(firstSide, 2);
                Console.WriteLine(Math.Round(area, 3));
            }

            if (figure.Equals("triangle"))
            {
                firstSide = double.Parse(Console.ReadLine());
                secondSide = double.Parse(Console.ReadLine());
                area = firstSide * secondSide / 2;
                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}
