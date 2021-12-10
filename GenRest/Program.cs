using System;

namespace GenRest
{
    class Alpha
    {
        protected int code;

        public Alpha(int n)
        {
            code = n;
        }

        public virtual void show()
        {
            Console.WriteLine("Класс Alpha: "+ code);
        }
    }

    class Bravo:Alpha
    {
        public  Bravo(int n): base(n){}

        public override void show()
        {
            Console.WriteLine("Класс Bravo: "+code);
        }
    }

    class Charlie:Bravo
    {
        public  Charlie(int n): base(n){}
        public override void show()
        {
            Console.WriteLine("Класс Charlie:"+code);
        }
    }

    class MyClass<T>where T: Alpha
    {
        public Alpha obj;

        public MyClass(T t)
        {
            obj = t;
            obj.show();
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Alpha A = new Alpha(100);
            Bravo B = new Bravo(200);
            Charlie C = new Charlie(300);
            MyClass<Alpha> objA = new MyClass<Alpha>(A);
            MyClass<Bravo> objB = new MyClass<Bravo>(B);
            MyClass<Charlie> objC = new MyClass<Charlie>(C);
            MyClass<Alpha> objD = new MyClass<Alpha>(C);
        }
    }
}