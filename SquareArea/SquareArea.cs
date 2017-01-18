using System;

namespace SquareArea
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a =  int.Parse(Console.ReadLine());
            Console.WriteLine("Square area = {0}", Math.Pow(a, 2));
            Console.ReadLine();
        }
    }
}
