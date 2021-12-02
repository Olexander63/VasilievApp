using System;

namespace Event
{
    delegate void MyDelegate(string txt);

    class MyClass
    {
        public event MyDelegate MyEvent;

        public void RaiseMyEvent(string txt)
        {
            if (MyEvent != null)
            {
                MyEvent(txt);
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
            Console.WriteLine("Обьект "+ name+":");
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
            obj.MyEvent += A.show;
            obj.RaiseMyEvent("2-e событие");
            Console.WriteLine();
            obj.MyEvent += B.show;
            obj.RaiseMyEvent("3-е событие");
            Console.WriteLine();
            obj.MyEvent -= A.show;
            obj.MyEvent -= B.show;
            obj.RaiseMyEvent("5-е событие");
            MyDelegate md = A.show;
            md += B.show;
            obj.MyEvent += md;
            obj.RaiseMyEvent("6-e событие");
        }
    }
}