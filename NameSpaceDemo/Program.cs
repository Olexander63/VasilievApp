using System;

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
            Console.WriteLine("Клас из First: "+ num);
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
            Console.WriteLine("Клас из  Seceond: "+ txt);
        }
    }

    class NameSpace
    {
        static void Main()
        {
            First.MyClass A = new First.MyClass(123);
            Second.MyClass B = new MyClass("text");
            A.show();
            B.show();
        }
    }
}