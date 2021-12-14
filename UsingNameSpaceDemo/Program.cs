using  System;

using  First;
using myclass = Second.MyClass;

namespace First
{

    class MyClass
    {
        public int num;

        public MyClass(int n)
        {
            num = n;
        }

        public void show()
        {
            Console.WriteLine("Класс из First: " + num);
        }

    }
}

namespace Second
{
    class MyClass
    {
        public string txt;

        public MyClass(string t)
        {
            txt = t;
        }

        public void show()
        {
            Console.WriteLine("Клас из Second: "+ txt);
        }
    }
}
namespace UsingNameSpaceDemo
{
     class Program
    {
        public static void Main(string[] args)
        {
            MyClass A = new MyClass(123);
            myclass B = new myclass("text");
            A.show();
            B.show();
        }
    }
}