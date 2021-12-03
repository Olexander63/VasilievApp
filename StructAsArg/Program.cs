using System;

namespace StructAsArg
{
    struct MyStruct
    {
        public char[] name;
        public int code;

        public MyStruct(string t, int n)
        {
            name = t.ToCharArray();
            code = n;
        }
    }

    class StructAsArgDemo
    {
        static void show(MyStruct A)
        {
            string txt = new string(A.name);
            Console.WriteLine("Символьный массив [{0}]",txt);
            Console.WriteLine("Числовое поле {0}",A.code);
        }

        static void maker(MyStruct A, ref MyStruct B, int k, char s)
        {
            Console.WriteLine("Выполняется метод maker()");
            Console.WriteLine("Первый аргумент");
            show(A);
            Console.WriteLine("Второй аргумент");
            show(B);
            A.name[k] = s;
            B.name[k] = s;
            A.code++;
            B.code++;
            Console.WriteLine();
            Console.WriteLine("Первый аргумент: ");
            show(A);
            Console.WriteLine("Второй аргумент");
            show(B);
            Console.WriteLine("Метод maker() завершен\n");
        }
        public static void Main(string[] args)
        {
            MyStruct A = new MyStruct("Alpha", 100);
            MyStruct B = new MyStruct("Bravo", 200);
            maker(A,ref B,4,'R');
            Console.WriteLine("После вызова метода maker()");
            Console.WriteLine("Экземпляр А:");
            show(A);
            Console.WriteLine("Экземпляр B:");
            show(B);
        }
        
    }
}