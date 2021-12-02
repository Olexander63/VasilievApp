using System;

namespace Lamda
{
    delegate int Alpha(int n);

    delegate void Bravo(string t);

    class MyClass
    {
        public int number;

        public MyClass(int n)
        {
            number = n;
        }

        public Alpha method;
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass A = new MyClass(100);
            MyClass B = new MyClass(200);
            A.method = (int n) => A.number + n;
            B.method = (int n) =>
            {
                return B.number - n;
            };
            int x = 80;
            Console.WriteLine("A.method({0})= {1}",x,A.method(x));
            A.number = 300;
            Console.WriteLine("A.method({0})= {1}",x,A.method(x));
            Console.WriteLine("B.method({0})= {1}",x,B.method(x));
            Bravo show;
            show =t=> Console.WriteLine("Текст: \"{0}\"", t);
            show = (string t) =>
            {
                for (int k = 0; k < t.Length; k++)
                {
                    Console.Write("|" + t[k]);
                }

                Console.WriteLine("|");
            };
            show("Bravo");
        }
    }
}