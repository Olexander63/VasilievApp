using System;

namespace WithoutSet
{
    class MyClass
    {
        public int first;
        public int last;

        public MyClass(int a, int b)
        {
            first = a;
            last = b;
        }
        public int sum
        {
            get { return first + last; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта:
            MyClass obj = new MyClass(1, 9);
            // Проверка значения свойства:
            Console.WriteLine("Сумма полей: " + obj.sum);
            // Присваивание значения полю:
            obj.first = 6;
            // Проверка значения свойства:
            Console.WriteLine("Сумма полей: " + obj.sum);
            // Присваивание значения полю:
            obj.last = 2;
            // Проверка значения свойства:
            Console.WriteLine("Сумма полей: " + obj.sum);
        }
    }
}
