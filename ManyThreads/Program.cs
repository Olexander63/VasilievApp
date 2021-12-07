using System;
using System.Threading;

namespace ManyThreads
{
    class MyClass
    {
        private int count;
        private int time;
        private string text;

        public void show()
        {
            Console.WriteLine(text+": Начало...");
            for (int i = 1; i <=count ; i++)
            {
                Console.WriteLine(text+" -> "+ i);
                Thread.Sleep(time);
            }

            Console.WriteLine(text+": Завершение...");
        }

        public MyClass(int c, int t, string txt)
        {
            count = c;
            time = t;
            text = txt;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Главный поток: Начало...");
            MyClass objA = new MyClass(5, 2000, "Поток А");
            MyClass objB = new MyClass(6, 1200, "Поток B");
            MyClass objC = new MyClass(8, 1000, "Поток C");
            Thread A = new Thread(objA.show );
            Thread B = new Thread(objB.show );
            Thread С = new Thread(objC .show );
            A.Start();
            B.Start();
            С.Start();
            Console.WriteLine("Главный поток: Завершение... ");
        }
    }
}