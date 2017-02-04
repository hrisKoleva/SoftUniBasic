using System;

namespace EqualWords
{
    class AreTheWordsEqual
    {
        static void Main(string[] args)
        {
            //поради някаква причина, при първия submit SoFTuNi/sOFtUnI не беше върнало резултат, при втори submit мина :-)
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