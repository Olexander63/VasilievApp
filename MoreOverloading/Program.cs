using System;

namespace MoreOverloading
{
    // Клас с перезагрузкой оператора "плюс"
    class MyClass
    {
        // Целочисленое поле:
        public int number;
        // Конструктор с одним аргументом:
        public MyClass(int n)
        {
            // Приисваивание значения полю:
            number = n;
        }
        // Переопределение  метода ToString():
        public override String ToString()
        {
            //  Результат метода:
            return "Поле number: " + number;
        }
        // Операторный метод для вычисления суммы двух обьектов:
        public static MyClass operator +(MyClass a, MyClass b)
        {
            // Целочисленная локальная переменная:
            int m = a.number + b.number;
            //Создание обьекта класа:
            MyClass t = new MyClass(m);
            // Резульатат метода:
            return t;
        }
        // Операторный метод для вычисления суммы обьекта и целого числа:
        public static MyClass operator +(MyClass a, int x)
        {
            // Целочисленная локальная переменная:
            int m = a.number + x;
            // рРезультат метода:
            return new MyClass(m);
        }
        // Операторный метод для вычисления суммы целого числа обьекта:
        public static MyClass operator +(int x, MyClass a)
        {
            // Результат метода:
            return a + x;
        }
        
        // Операторный метода для унарного оператора "плюс"
        public static int operator +(MyClass a)
        {
            //Результат метода:
            return a.number;
        }
        
        // Клас с главным методом:
        
    }
    class MoreOverloadingPlus
    {
        public static void Main(string[] args)
        {
            // Создание обьектов:
            MyClass A = new MyClass(100);
            MyClass B = new MyClass(200);
            // Вычисление суммы обьекта:
            MyClass C = A + B;
            // Проверка результата:
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            
            // Вычисление суммы обьекта и целого числа:
            C = A + 1;
            // Проверка результата:
            Console.WriteLine(C);
            // Вычисление суммы целого числа и обьекта:
            C = 10 + A;
            // Проверка результата:
            Console.WriteLine(C);
            Console.Write("Унарный оператор: ");
            // Используеться унарный "плюс":
            Console.WriteLine(+C);
            int num = (+A) + (+B);
            // Проверка результата:
            Console.WriteLine("Сумма чисел:" +num);
        }
    }
}