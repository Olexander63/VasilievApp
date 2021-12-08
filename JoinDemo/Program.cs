using System;
using System.Threading;

namespace JoinDemo
{   

    internal class Program
    {
        static void run()
        {
            Console.WriteLine("Дочерний поток запущен...");
            for (int k = 1; k <=5 ; k++)
            {
                Console.WriteLine("Дочерний поток: " + k);
                Thread.Sleep(2500);
            }

            Console.WriteLine("Дочерний поток завершен...");

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Главный потокзапущен...");
            Thread t = new Thread(run);
            t.Start();
            for (char s = 'A'; s <= 'F'; s++)
            {
                Console.WriteLine("Главный поток: "+s);
                Thread.Sleep(1000);
                if (t.IsAlive) t.Join();
                Console.WriteLine("Главный поток завершен...");
            }
        }
    }
}