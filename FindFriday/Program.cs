using System;

namespace FindFriday
{
    internal class FindFridayDemo
    {
        public static void Main(string[] args)
        {
            int start = 2015, end = 2020, day = 13;
            DateTime date;
            Console.WriteLine("Пятница: ");
            for (int year = start; year <= end; year++)
            {
                for (int month = 1; month <=12; month++)
                {
                    date = new DateTime(year, month, day);
                    if (date.DayOfWeek ==DayOfWeek.Friday)
                    {
                        Console.WriteLine(date.ToString("dd MMMM yyyy года"));
                    }
                }
            }
        }
    }
}