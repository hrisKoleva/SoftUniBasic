using System;

namespace InchesToCentimeters
{
    class InchToCentemeterConverter
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            const double coefficient = 2.54;
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * coefficient;
            Console.Write("centimeters = {0}", centimeters);
            Console.ReadLine();
        }
    }
}
