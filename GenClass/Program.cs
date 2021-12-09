using System;

namespace GenClass
{
    class Alpha<X>
    {
        public  X code;

        public Alpha(X a)
        {
            code = a;
        }

        public void show()
        {
            Console.WriteLine("Поле типа {0}: {1}",typeof(X).Name,code);
        }
    }

    class Bravo<X,Y>
    {
        public X first;
        public Y second;

        public Bravo(X a, Y b)
        {
            first = a;
            second = b;
        }

        public void show()
        {
            Console.WriteLine("Первое поле типа {0}: {1}",typeof(X).Name,first);
            Console.WriteLine("Второе поле типа {0}: {1}",typeof(Y).Name,second);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Alpha<int> A = new Alpha<int>(123);
            Alpha<string> B = new Alpha<string>("object B");
            Alpha<char> C = new Alpha<char>('C');
            A.show();
            B.show();
            C.show();
            Console.WriteLine();
            Bravo<int, char> objA = new Bravo<int, char>(123, 'A');
            Bravo<string, bool> objB = new Bravo<string, bool>("objB", true);
            Bravo<char, char> objC = new Bravo<char, char>('B', 'C');
            objA.show();
            objB.show();
            objC.show();
        }
    }
}