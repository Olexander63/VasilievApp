using System;

namespace StructAndEvent
{
    delegate void MyDelegate(string t);
    struct Alpha
    {
        public string name;
        private MyDelegate myevent;
        public event MyDelegate MyEvent
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

        public Alpha(string t)
        {
            name = t;
            myevent = null;
        }

        public void RaiseMyEvent()
        {
            if (myevent != null) myevent("Alpha: " + name);
        }
    }

    struct Bravo
    {
        public string name;
        public event MyDelegate MyEvent;

        public void RaiseMyEvent()
        {
            if (MyEvent != null) MyEvent("Bravo: " + name);
        }
    }
    class Program
    {
        static void show(string t)
        {
            Console.WriteLine("Произошло событие");
            Console.WriteLine(t);
            Console.WriteLine("-----------------");
        }
        public static void Main(string[] args)
        {

            Alpha A = new Alpha("Экземпляр А");
            A.MyEvent += show;
            A.RaiseMyEvent();
            Bravo B = new Bravo();
            B.name = "Экземпляр B";
            B.MyEvent += show;
            B.RaiseMyEvent();
        }
    }
}