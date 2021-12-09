using System;

namespace GenInterface
{
    interface MyInterface<X,Y>
    {
        void set(X a, Y b);
        void show();
    }

    class Alpha<X,Y>:MyInterface<X,Y>
    {
        private X first;
        private Y second;

        public void set(X a, Y b)
        {
            first = a;
            second = b;
        }

        public void show()
        {
            Console.WriteLine("Поеля {0} и {1}",first,second);
        }
    }

    class Bravo<Y>:MyInterface<int,Y>
    {
        private int first;
        private Y second;

        public void set(int a, Y b)
        {
            first = a;
            second = b;
        }

        public void show()
        {
            Console.WriteLine("Поля {0} и {1}",first,second);
        }
    }

    class Charlie:MyInterface<int,char>
    {
        private int first;
        private char second;

        public void set(int a, char b)
        {
            first = a;
            second = b;
        }

        public void show()
        {
            Console.WriteLine("Поля {0} и {1}",first,second);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Первый обьект");
            Alpha<string, double> A = new Alpha<string, double>();
            MyInterface<string, double> Ra = A;
            A.set("Alpha",100.0);
            Ra.show();
            Ra.set("alpha",150.0);
            A.show();
            Console.WriteLine("Второй обьект");
            Bravo<string> B = new Bravo<string>();
            MyInterface<int, string> Rb = B;
            B.set(200,"Bravo");
            Rb.show();
            Rb.set(250,"bravo");
            B.show();
            Console.WriteLine("Третий обьект");
            Charlie C = new Charlie();
            MyInterface<int, char> Rc= C;
            C.set(300, 'C');
            Rc.show();
            Rc.set(350,'D');
            C.show();
        }
    }
}