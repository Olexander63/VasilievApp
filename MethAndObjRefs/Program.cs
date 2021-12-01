using System;

namespace MethAndObjRefs
{
    delegate void MyDelegate(int n);

    class MyClass
    {
        private int number;

        public MyClass(int n)
        {
            set(n);
        }

        public void set(int n)
        {
            number = n;
        }

        public override string ToString()
        {
            return "Поле number=" + number;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass A = new MyClass(100);
            MyClass B = A;
            MyDelegate aplpy = A.set;
            A = new MyClass(200);
            Console.WriteLine(A);
            Console.WriteLine(B);
            aplpy(300);
            Console.WriteLine();
            Console.WriteLine(A);
            Console.WriteLine(B);
        }
    }
}