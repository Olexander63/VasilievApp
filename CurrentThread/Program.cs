using System;
using System.Threading;

namespace CurrentThread
{
    class Program
    {
        static int state = 0;
        static void run(bool type)
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine("Поток "+t.Name+" запущен...");
            while (true)
            {
                if (type) state++;
                else state--;
                Thread.Sleep(1000);
            }
        }
        static void Main()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Base";
            Console.WriteLine("Главный поток {0} запущен... ", t.Name);
            Console.WriteLine("Начальное значение: {0}",state);
            Thread up = new Thread(()=>run(true));
            Thread down = new Thread(() => run((false)));
            up.Name = "Alpha";
            up.Priority = ThreadPriority.Highest;
            down.Name = "Bravo";
            down.Priority = ThreadPriority.Lowest;
            up.Start();
            down.Start();
            Thread.Sleep(5000);
            up.Abort();
            down.Abort();
            Console.WriteLine("Итоговое значение: {0}",state);
            Console.WriteLine("Главный поток {0} завершен...",t.Name);
        }
    }
}