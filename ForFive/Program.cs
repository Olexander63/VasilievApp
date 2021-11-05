using System;

namespace ForFive
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = 10, k = 1, s = 0;
            Console.WriteLine("Сумма 1 + 3 + 5 +..+ {0}", 2 * n - 1);
            for (;;)
            {
                s += 2 * k - 1;
                k++;
                if (k > n) break;
            }

            Console.WriteLine(s);
        }
    }
}