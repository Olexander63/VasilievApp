using System;
using System.Threading;

namespace ThreadsStart
{
    class MyClass
    {
        private string text;
        private int time;

        public MyClass(string txt, int t)
        {
            text = txt;
            time = t;
        }

        public void show()
        {
            for (int k = 1; k <=5 ; k++)
            {
                Console.WriteLine(text +"\t" + k);
                Thread.Sleep(time);
            }
        }
    }
    internal class Program
    {
        static void run(string text, int time)
        {
            for (int k = 1; k <=5; k++)
            {
                Console.WriteLine(text+ "\t"+ k);
                Thread.Sleep(time);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Главный поток запущен...");
            MyClass A = new MyClass("Обьект A", 1000);
            MyClass B = new MyClass("Обьект B", 1500);
            ThreadStart ts = A.show;
            ts += B.show;
            Thread first = new Thread(ts);
            Thread second = new Thread(() =>
            {
                run("Метод Alpha", 1200);
                run("Метод Bravo", 800);
            });
            first.Start();
            second.Start();
            if (first.IsAlive) first.Join();
            if (second.IsAlive) second.Join();
            Console.WriteLine("Главный поток завершен");
        }
    }
}