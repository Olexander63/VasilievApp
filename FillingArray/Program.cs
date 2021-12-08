using System;
using System.Threading;

namespace FillingArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int size = 20;
            char[] symbs = new char[size];
            for (int k = 0; k <symbs.Length; k++)
            {
                symbs[k] = '*';
                Console.Write("|"+ symbs[k]);
            }

            Console.WriteLine("|");
            int first = 0, second = symbs.Length - 1;
            Thread A, B;
            A = new Thread(() =>
            {
                char start = 'Я';
                while (true)
                {
                    if (second > first)
                    {
                        symbs[second] = start;
                        start--;
                        second--;
                        Thread.Sleep(100);
                    }
                    else
                    {
                        Thread.CurrentThread.Abort();
                    }
                }
            });
            B = new Thread(() =>
            {
                char start = 'A';
                while (true)
                {
                    if (first < second)
                    {
                        symbs[first] = start;
                        start++;
                        first++;
                        Thread.Sleep(100);
                    }
                    else
                    {
                        Thread.CurrentThread.Abort();
                    }
                }
            });
            A.Start();
            B.Start();
            if (A.IsAlive) A.Join();
            if (B.IsAlive) B.Join();
            for (int k = 0; k < symbs.Length; k++)
            {
                Console.Write("|"+symbs[k]);
            }

            Console.WriteLine("|");
        }
    }
}