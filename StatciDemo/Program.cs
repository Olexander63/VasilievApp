using System;

namespace StatciDemo
{
    // Клас со статическим методами и полями:
    class MyMath
    {
        //Константное поле ("пи"):
        public const double Pi = 3.141592;
        //Закрыое статическо поле (граница суммы):
        private static int N = 100;
        // Статический метод для вычисления  экспоненты:
        public static double exp(double x)
        {
            //Сумма и добавка к сумме:
            double s = 0, q = 1;
            // Вычисление суммы:
            for (int k = 0; k <=N; k++)
            {
                s += q;  // Прибавление  добавки к сумме
                q *= x / (k + 1);  // Добавка для следующей итерации
            }
            // Результат:
            return s;
        }
        
        // Статический метод для вычисления синуса:
        public static double sin(double x)
        {
            //Сумма и добавка к сумме:
            double s = 0, q = x;
            // Вычисление суммы:
            for (int k = 0; k <=N; k++)
            {
                s += q; //Прибавление добавки к сумме:
                // Добавка для следующей итерации:
                q *= (-1) *x * x/(2 * k + 2) / (2 * k + 3);
            }
            //Резульат:
            return s;
        }

    }
    
    //Главный класс:
    
    
    class Program
    {
        public static void Main(string[] args)
        {
            // Аргумент для статических методов:
            double z = 1;
            //  Вычисление экспоненты:
            Console.WriteLine("exp({0} =p{1})",z, MyMath.exp(z));
            //Контролное значение:
            Console.WriteLine("Контрольное значение: {0}", Math.Exp(z));
            //Новое значение аргумента:
            z = MyMath.Pi / 4;
            // Вычисление синуса:
            Console.WriteLine("sin({0}={1})",z, MyMath.sin(z));
            //Контроьное значение:
            Console.WriteLine(": Контольное значение: {0}", MyMath.sin(z));
        }
        
    }
}