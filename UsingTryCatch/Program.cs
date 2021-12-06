using System;

namespace UsingTryCatch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Начинается выполнение программы");
            int A = 10, B=0;
            Console.WriteLine("Переменная А="+A);
            Console.WriteLine("Переменная B="+B);
            try
            {

                Console.WriteLine("Вычисляется выражение A/B");
                Console.WriteLine("Результат: "+A/B);
                Console.WriteLine("Вычисления закончены");
            }
            catch (Exception e)
            {
                Console.WriteLine("Возникла ошибка!");
                Console.WriteLine("Тип ошибки: "+ e.GetType().Name);
                Console.WriteLine("описание: " + e.Message);
                Console.WriteLine("Программ: "+ e.Source);
                Console.WriteLine("Метод: "+e.TargetSite.Name);
                Console.WriteLine("Место ошибки: "+ e.StackTrace);
                Console.WriteLine("Программа завершила выполнение");
            }
        }
    }
}