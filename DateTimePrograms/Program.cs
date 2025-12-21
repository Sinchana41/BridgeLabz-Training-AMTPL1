using System;

namespace DateTimePrograms
{
    class Program1
    {
        public static void Main()
        {
            DateTime Now = DateTime.Now;
            Console.WriteLine(Now);//02-12-2025 15:31:33
            
            DateTime Today = DateTime.Today;
            Console.WriteLine(Today);//02-12-2025 00:00:00

            DateTime UTC = DateTime.UtcNow;//Coordinated Universal Time
            Console.WriteLine(UTC);//02-12-2025 10:02:53

            DateTime DateOfBirth = new DateTime(2002, 10, 29);
            Console.WriteLine(DateOfBirth);//29-10-2002 00:00:

            DateTime DateOfBirthWithTime = new DateTime(2002, 10, 29,11,49,56);//new DateTime(year, month, day, hour, minute, second)
            Console.WriteLine(DateOfBirthWithTime);//29-10-2002 11:49:56

            //Adding or Subtracting Time
            DateTime d = DateTime.Now;

            DateTime nextWeek = d.AddDays(7);
            Console.WriteLine(nextWeek);//09-12-2025 15:45:29 - (2+7)
            DateTime previousMonth = d.AddMonths(-1);
            Console.WriteLine(previousMonth);//02-11-2025 15:45:29 - (12-1)
            DateTime nextHour = d.AddHours(1);
            Console.WriteLine(nextHour);//02-11-2025 16:45:29 - (15+1)

            //Difference Between Two Dates
            DateTime d1 = new DateTime(2002, 10, 29);//Date of Birth
            DateTime d2 = new DateTime(2025, 12, 2);//Todays date

            TimeSpan diff = d2 - d1;

            Console.WriteLine(diff.Days); // 8435 days

            //Extracting Date Parts
            DateTime dt = DateTime.Now;

            int y = dt.Year;
            Console.WriteLine(y);//2025
            int m = dt.Month;
            Console.WriteLine(m);//12
            int day = dt.Day;
            Console.WriteLine(day);//2
            int h = dt.Hour;
            Console.WriteLine(h);//15
            int min = dt.Minute;
            Console.WriteLine(min);//57
            int sec = dt.Second;
            Console.WriteLine(sec);//47

            DateTime D = DateTime.Parse("2025-11-02");
            Console.WriteLine(D);//02-11-2025 00:00:00

            DateTime D1 = DateTime.Now;
            DateTime D2 = DateTime.Now.AddHours(2);
            Console.WriteLine(D1.DayOfWeek);//Tuesday
            Console.WriteLine(D1.Date);//02-12-2025 00:00:00
            Console.WriteLine(D1.TimeOfDay);//16:28:47.4917921
            Console.WriteLine(D2.DayOfYear);//336
            if (D1 < D2)
            {
                Console.WriteLine("D2 is Later");//D2 is Later
            }
        }
    }
}