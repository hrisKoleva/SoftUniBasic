using System;

namespace BonusScore
{
    class CalculateBonusScore
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            double bonusScore = 0; 
            double totalBonus = 0;

            if (score <= 100)
            {
                bonusScore += 5;
            }
            else if (score <=1000)
            {
                bonusScore += score*0.2;
            }
            if(score>1000)
            {
                bonusScore += score * 0.1;
            }
            if(score%2==0)
            {
                bonusScore += 1;
            }
           else if (score %5==0 )
            {
                bonusScore += 2;
            }

            totalBonus = score + bonusScore;

            Console.WriteLine(bonusScore);
            Console.WriteLine(totalBonus);
        }
    }
}
