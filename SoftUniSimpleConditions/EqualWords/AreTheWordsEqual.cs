using System;

namespace EqualWords
{
    class AreTheWordsEqual
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            if(firstWord.ToLower().Trim().Equals(secondWord.ToLower().Trim()))
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