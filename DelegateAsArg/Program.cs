using System;

namespace DelegateAsArg
{
    delegate int MyDelegate(int n);
     class DelegateAsArgDemo
    {
        static int f(int n)
        {
            return 2 * n + 1;
        }

        static int g(int n)
        {
            return 2 * n;
        }

        static int h(int n)
        {
            return n * n;
        }

        static void display(MyDelegate F, int a, int b)
        {
            Console.WriteLine("{0,-4}|{1,4}","x","F(x)");
            Console.WriteLine("--------");
            for (int k = a; k <= b; k++)
            {
                Console.WriteLine("{0,4}|{1,4}", k, F(k));
            }

            Console.WriteLine();
        }
        public static void Main()
        {
            int a = 0, b = 5;
            Console.WriteLine("Нечетные числа:");
            display( f,a,b);
            Console.WriteLine("Четные числа:");
            display(g,a,b);
            Console.WriteLine("Число в квадрате :");
            display(h,a,b);
        }
    }
}