using System;

namespace GenStruct
{
    struct MyStruct<X,Y>
    {
        public X first;
        public Y second;

        public MyStruct(X a, Y b)
        {
            first = a;
            second = b;
        }

        public void show()
        {
            Console.WriteLine("Первое поле: {0}",first);
            Console.WriteLine("Второе поле: {0}",second);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyStruct<string, int> A;
            A.first = "MyStruct";
            A.second = 100;
            A.show();
            MyStruct<char, int> B = new MyStruct<char, int>('B', 200);
            B.show();
        }
    }
}