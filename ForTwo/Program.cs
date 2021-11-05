using System;

namespace ForTwo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = 10, s = 0;
            Console.WriteLine("Сумма 1 +3 + 5 +...+ {0}=", 2 * n - 1);
            for (var k = 1; k <= n; k++)
                s += 2 * k - 1;
            Console.WriteLine(s);
        }
    }
}