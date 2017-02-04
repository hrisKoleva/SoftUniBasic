using System;

namespace TimePlusFifteenMinutes
{
    class WhenIsFifteenMinutesFromTime
    {
        static void Main(string[] args)
        {
            DateTime time = new DateTime();

            string inputHours = string.Format("{0:H}", Console.ReadLine());
            string inputMinutes = string.Format("{0:mm}", Console.ReadLine());

            time = time.AddHours(double.Parse(inputHours));
            time = time.AddMinutes(double.Parse(inputMinutes));

            DateTime endTime = time.AddMinutes(15);

            Console.WriteLine("{0:H:mm}", endTime);
        }
    }
}