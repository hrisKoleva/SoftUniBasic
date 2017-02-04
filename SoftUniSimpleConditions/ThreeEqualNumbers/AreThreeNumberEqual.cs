using System;

namespace ThreeEqualNumbers
{
    class AreThreeNumberEqual
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            bool areEqual = numberOne == numberTwo && numberTwo == numberThree;
            if(areEqual)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}