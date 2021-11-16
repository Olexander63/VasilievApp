using System;

namespace MoreOverloadingComps
{
    // Клас с перегружеными операторами сравнения
    class MyClass
    {
        // Целочисленное поле:
        public int code;

        // Конструктор с одним аргументом:
        public MyClass(int n)
        {
            // Присваивание значения полю:
            code = n;
        }

        // Перегрузка оператора "меньше или равно":
        public static MyClass operator <=(MyClass a, MyClass b)
        {
            if (a.code <= b.code) return a;
            return b;
        }

        // Перегрузка оператора "больше или равно":
        public static MyClass operator >=(MyClass a, MyClass b)
        {
            if (a.code >= b.code) return a;
            return b;
        }

        // Перегрузка оператора "меньше или равно":
        public static bool operator <=(MyClass a, int x)
        {
            if (a.code <= x - 1) return true;
            return false;
        }

        // Перегрузка оператора "больше или равно":
        public static bool operator >=(MyClass a, int x)
        {
            if (a.code >= x + 1) return true;
            return false;
        }

        // Перегрузка оператора "меньше":
        public static bool operator <(MyClass a, MyClass b)
        {
            return a.code < b.code;
        }

        // Перегрузка оператора "больше":
        public static bool operator >(MyClass a, MyClass b)
        {
            return a.code > b.code;
        }

        // Перегрузка оператора "меньше":
        public static int operator <(MyClass a, int x)
        {
            return x - a.code;
        }

        // Перегрузка оператора "больше":
        public static int operator >(MyClass a, int x)
        {
            return a.code - x;
        }
    }

    class Program
    {
        public static void Main()
        {
            // Создание объектов:
            MyClass A = new MyClass(100);
            MyClass B = new MyClass(200);
            // Проверка результата:
            Console.WriteLine("Объект A: {0}", A.code);
            Console.WriteLine("Объект B: {0}", B.code);
            // Использование операторов "меньше" и "больше":
            Console.WriteLine("A<B дает {0}", A < B);
            Console.WriteLine("A>B дает {0}", A > B);
            // Объектная переменная:
            MyClass C;
            // Использование оператора "больше или равно":
            C = A >= B;
            // Новое значение поля:
            C.code = 300;
            // Проверка результата:
            Console.WriteLine("Объект B: {0}", B.code);
            // Использование оператора "меньше или равно":
            C = A <= B;
            // Новое значение поля:
            C.code = 150;
            // Проверка результата:
            Console.WriteLine("Объект A: {0}", A.code);
            // Новое значение поля:
            (B <= A).code = 500;
            // Проверка результата:
            Console.WriteLine("Объект A: {0}", A.code);
            // Целочисленные переменные:
            int x = 400, y = 500, z = 600;
            // Использование операторов "меньше или рано" и
            // "больше или равно":
            Console.WriteLine("A<={0} дает {1}", x, A <= x);
            Console.WriteLine("A>={0} дает {1}", x, A >= x);
            Console.WriteLine("A<={0} дает {1}", y, A <= y);
            Console.WriteLine("A>={0} дает {1}", y, A >= y);
            Console.WriteLine("A<={0} дает {1}", z, A <= z);
            Console.WriteLine("A>={0} дает {1}", z, A >= z);
            // Использование операторов "меньше" и "больше":
            Console.WriteLine("A<{0} дает {1}", z, A < z);
            Console.WriteLine("A>{0} дает {1}", x, A > x);
        }
    }
}