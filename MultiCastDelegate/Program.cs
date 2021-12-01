using System;

namespace MultiCastDelegate
{
    delegate void MyDelegate();

    class MyClass
    {
        public string name;

        public MyClass(string txt)
        {
            name = txt;
        }

        public void show()
        {
            Console.WriteLine(name);
        }
    }

    class  Multicast
    {
       public static void makeLine()
        {
            Console.WriteLine("------");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            MyClass A = new MyClass("Обьект А");
            MyClass B = new MyClass("Обьект B");
            MyClass C = new MyClass("Обьект C");
            MyDelegate meth;
            meth = A.show;
            meth();
            meth = Multicast.makeLine;
            meth += A.show;
            meth += B.show;
            meth =meth+ C.show;
            meth();
            meth-= B.show;
            meth();
            meth = meth - A.show;
            meth();
        }
    }
}