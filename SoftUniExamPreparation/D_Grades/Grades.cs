using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double grade = 0;
           
            double sum = 0;
            double average = 0;

            double percentFirst = 0; ;
            double percentSecond = 0;
            double percentThird = 0;
            double percentFourth = 0;


            for (int i = 0; i < n; i++)
            {
                grade = double.Parse(Console.ReadLine());
                sum += grade;

                if (grade>= 2.00 && grade <=2.99)
                {
                    percentFirst++;
                }
                else if(grade >= 3.00 && grade <= 3.99)
                {
                    percentSecond++;
                }
                else if(grade >= 4.00 && grade <= 4.99)
                {
                    percentThird++;
                }

                else if(grade >= 5.00)
                {
                    percentFourth++;
                }

            }

            average = sum / n;

            //Top students: 30.00%
            Console.WriteLine($"Top students: {(percentFourth*100/n).ToString("0.00")}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(percentThird * 100 / n).ToString("0.00")}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(percentSecond * 100 / n).ToString("0.00")}%");
            Console.WriteLine($"Fail: {(percentFirst * 100 / n).ToString("0.00")}%");
            Console.WriteLine($"Average: {(sum/n).ToString("0.00")}");

        }
    }
}
