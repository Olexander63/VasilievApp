using System;
using System.Threading;

namespace ThreadInThread
{
    class Program
    {
        static void fill(int[,] a, int k, Random rnd)
        {
            Thread t = null;
            if (k < a.GetLength(0) - 1)
            {
                t = new Thread(() =>
                {
                    fill(a,k+1,rnd);
                });
                t.Start();
            }

            for (int m = 0; m <a.GetLength(1); m++)
            {
                a[k, m] = k * 10 + rnd.Next(10);
            }

            // if (t! = null && t.IsAlive) t.Join();
        }
        public static void Main(string[] args)
        {
            int[,] nums = new int[6, 9];
            Random rnd = new Random();
            fill(nums,0,rnd);
            for (int i = 0; i <nums.GetLength(0); i++)
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