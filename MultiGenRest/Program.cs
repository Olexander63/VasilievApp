using System;
namespace MultiGenRest
{
    class Alpha
    {
        public int code;
        public override string ToString()
        {
            return "Alpa: " + code;
        }
    }

    class Bravo : Alpha
    {
        public string text;
        public override string ToString()
        {
            return "Bravo: " + code + " и " + text;
        }
    }

    class MyClass<X, Y>
        where X : class, new()
        where Y : X, new()
    {
        public X first;
        public Y second;

        public MyClass()
        {
            first = new X();
            second = new Y();


        }

        public override string ToString()
        {
            return "MyClass->|" + first + "|" + second + "|";
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<Alpha, Bravo> obj = new MyClass<Alpha, Bravo>();
            obj.first.code = 100;
            obj.second.code = 200;
            obj.second.text = "text";
            Console.WriteLine(obj);
        }
    }
}
