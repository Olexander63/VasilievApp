using System;

namespace EventDemo
{
    delegate void MyDelegate(string txt);

    class MyClass
    {
        private MyDelegate myevent;
        public  event  MyDelegate Myevent
        {
            add
            {
                myevent += value;
            }
            remove
            {
                myevent -= value;
            }
        }

        public void RaiseMyEvent(string txt)
        {
            if (myevent != null)
            {
                myevent(txt);
            }
        }
    }

    class Alpha
    {
        public string name;

        public Alpha(string txt)
        {
            name = txt;
        }

        public void show(string msg)
        {
            Console.WriteLine("Обьект " +name+":");
            Console.WriteLine(msg);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Alpha A = new Alpha("A");
            Alpha B = new Alpha("B");
            obj.RaiseMyEvent("1-e событие");
            obj.Myevent += A.show;
            obj.RaiseMyEvent("2-е событие");
            Console.WriteLine();
            obj.RaiseMyEvent("3-е событие");
            Console.WriteLine();
            obj.Myevent -= A.show;
            obj.RaiseMyEvent("4-е событие");
            Console.WriteLine();
            obj.Myevent -= A.show;
            obj.Myevent -= B.show;
            obj.RaiseMyEvent("5-е событие");
            MyDelegate md = A.show;
            md += B.show;
            obj.Myevent += md;
            obj.RaiseMyEvent("6-е событие");

        }
    }
}