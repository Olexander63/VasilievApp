using System;
using System.Threading;

namespace Background
{
    internal class Program
    {
        static void run()
        {
            Console.WriteLine("Дочерний поток запущен...");
            int k = 1;
            while (true)
            {
                Console.WriteLine("Дочерний поток: "+ k);
                k++;
                Thread.Sleep(2100);
            }
        }
        static void Main()
        {
            Console.WriteLine("Главный поток запущен...");
            Thread t = new Thread(run);
            t.IsBackground = true;
            t.Start();
            for (char s ='A'; s <= 'F'; s++)
            {
                Console.WriteLine("Главный поток: " +s);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Главный поток завершен...");
        }
    }
}