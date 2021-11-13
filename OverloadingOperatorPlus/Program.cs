using System;

namespace OverloadingOperatorPlus
{   
    // Класс с перегрузкой оператора сложения:
    class MyClass
    {
        // Целочисленное поле:
        public int number;
        // Конструктор с целочисленным аргументом:
        public MyClass(int n)
        {
            // Присваивание значения полю:
            number = n;
        }
        
        //  Операторный метод для перегрузки оператора сложения:
        public static int operator +(MyClass a, MyClass b)
        {
            // локальная циелочисленная переменная:
            int m = a.number + b.number;
            // Результат метода:
            return m;
        }

    }
    class OverloadingOperatorsPlus
    {
        // Главный метод:
        public static void Main(string[] args)
        {
            // Создание обьектов класса  MyClass:
            MyClass A = new MyClass(100);
            MyClass B = new MyClass(200);
            // Целочисленная переменная:
            int num;
            // Вычисление суммы обьектов:
            num = A + B;
            // отображение результата вычисления суммы обьектов:
            Console.WriteLine("A+B=" +num);
        }
    }
}