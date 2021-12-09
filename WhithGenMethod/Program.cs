using System;

namespace WhithGenMethod
{
    class MyClass
    {
        public string text;

        public MyClass(string t)
        {
            text = t;
        }

        public void show<X>(X arg)
        {
            Console.WriteLine(text+": "+ arg);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass A = new MyClass("Alpha");
            MyClass B = new MyClass("Bravo");
            A.show(100);
            B.show(200);
            A.show('A');
            B.show<char>('B');
            B.show<int>('B');

        }
    }
}