using System;
using System.Threading;

namespace ThreadArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] nums = new int[6, 9];
            Thread[] t = new Thread[nums.GetLength(0)];
            for (int i = 0; i < t.Length; i++)
            {
                int p = i;
                t[i] = new Thread(() =>
                {
                    for (int j = 0; j <nums.GetLength(1); j++)
                    {
                        nums[p, j] = (p + 1) * (j + 1);
                        Thread.Sleep(100);
                    }
                });
                t[i].Start();
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].IsAlive) t[i].Join();
            }

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write("{0,-4}",nums[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}