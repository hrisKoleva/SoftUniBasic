using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string examTimeHours = string.Format("{0:H}", Console.ReadLine());
            string examTimeMinutes = string.Format("{0:mm}", Console.ReadLine());
            string arrivalHours = string.Format("{0:H}", Console.ReadLine());
            string arrivalMinutes = string.Format("{0:mm}", Console.ReadLine());

            DateTime examTime = new DateTime();
            DateTime arrivalTime = new DateTime();

            TimeSpan delta;

            examTime = examTime.AddHours(double.Parse(examTimeHours));
            examTime = examTime.AddMinutes(double.Parse(examTimeMinutes));

            arrivalTime = arrivalTime.AddHours(double.Parse(arrivalHours));
            arrivalTime = arrivalTime.AddMinutes(double.Parse(arrivalMinutes));

            delta = (examTime - arrivalTime);

            if (arrivalTime.CompareTo(examTime) < 0)
            {
                if (delta.Duration().Hours > 0)
                {
                    Console.WriteLine("early");
                    Console.WriteLine($"{delta.ToString(@"h\:mm")} hours before the start");
                }
                else
                {
                    if (delta.Duration().Minutes <= 30)
                    {
                        Console.WriteLine("on time");
                        Console.WriteLine($"{delta.Duration().Minutes} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine("early");
                        Console.WriteLine($"{delta.Duration().Minutes} minutes before the start");

                    }
                }
            }
            else if (arrivalTime.CompareTo(examTime) > 0)
            {
                Console.WriteLine("late");
                if (delta.Duration().Hours > 0)
                {

                    Console.WriteLine($"{delta.ToString(@"h\:mm")} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{delta.Duration().Minutes} minutes after the start");

                }
            }
            else
            {
                Console.WriteLine("on time");

            }
        }
    }
}
