using System;

namespace StructAndInterface
{
    interface MyInterface
    {
        void set(int n);
        void show();
    }

    struct MyStruct:MyInterface
    {
        private int code;

        public void set(int n)
        {
            code = n;
        }

        public void show()
        {
            Console.WriteLine("Числовое поле: "+ code);
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            MyStruct A = new MyStruct();
            A.set(100);
            Console.WriteLine("Экземпляр А:");
            A.show();
            MyInterface R;
            R = A;
            Console.WriteLine("Переменная R:");
            R.show();
            Console.WriteLine("Экземпляр A:");
            A.show();
        }
    }
}