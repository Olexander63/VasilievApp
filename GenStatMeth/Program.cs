using System;

namespace GenStatMeth
{
    class MyClass
    {
        public int code;

        public MyClass(int n)
        {
            code = n;
        }

        public override string ToString()
        {
            return "поле =" + code;
        }

        public static implicit operator int(MyClass obj)
        {
            return obj.code;
        }

        public static implicit operator MyClass(int n)
        {
            return new MyClass(n);
        }
    }

    class GenStatMethDemo
    {
        static void show<T>(T arg)
        {
            Console.WriteLine("Обобщенный параметр: {0}", typeof(T).Name);
            Console.WriteLine("Значение аргумента:  {0}", arg);
            Console.WriteLine("-------------------------------");
        }

        static void Main()
        {
            show(100);
            show<int>(200);
            show<double>(300);
            show<MyClass>(400);
            show('A');
            show<char>('B');
            show<int>('C');
            show("Alpha");
            MyClass obj = new MyClass(500);
            show(obj);
            show<int>(obj);
        }
    }
}
