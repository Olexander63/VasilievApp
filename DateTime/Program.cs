using System;

namespace DateTimeDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Текущая дата: :{0}", DateTime.Today);
            Console.WriteLine("Дата и время {0}",today);
            Console.WriteLine("Год: {0}",today.Year);
            Console.WriteLine("Высокосный: {0}",DateTime.IsLeapYear(today.Year));
            Console.WriteLine("Месяц: {0}",today.Month);
            Console.WriteLine("День недели: {0}",today.DayOfWeek);
            Console.WriteLine("День в году: {0}",today.DayOfYear);
            Console.WriteLine("Часи:{0}",today.Hour);
            Console.WriteLine("Минуты : {0}",today.Minute);
            Console.WriteLine("Секунды : {0}",today.Second);
            Console.WriteLine("Миллисекунды : {0}",today.Millisecond);
            Console.WriteLine("Такты: {0}",today.Ticks);
            DateTime date = new DateTime(1974, 10, 22, 6, 16, 12);
            Console.WriteLine(date.ToString("Новая дата: dd MMMM yyyy; время - HH:mm:ss"));
            TimeSpan time = new TimeSpan(17, 71, 125);
            Console.WriteLine("Интервал времени: {0}",time);
            Console.WriteLine("Еще одна дата: : {0}", date.Add(time));
            Console.WriteLine("Разность дат (дней): {0}",(today-date).Days);
            Console.WriteLine("Разность дат (тактов): {0}",(today - date).Ticks);
        }
    }
}