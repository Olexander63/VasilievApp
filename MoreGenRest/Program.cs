using System;

namespace MoreGenRest
{
    class Alpha
    {
        public int code;

        public override string ToString()
        {
            return "Alpha: " + code;
        }
    }

    class Bravo
    {
        public string text;

        public override string ToString()
        {
            return "Bravo: " + text;
        }
    }

    class MyClass<T> where T: new()
    {
        public T obj;

        public MyClass()
        {
            obj = new T();
        }

        public void show()
        {
            Console.WriteLine(obj);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass<Alpha> objA = new MyClass<Alpha>();
            objA.obj.code = 123;
            objA.show();
            MyClass<Bravo> objB = new MyClass<Bravo>();
            objB.obj.text = "text";
            objB.show();
        }
    }
}