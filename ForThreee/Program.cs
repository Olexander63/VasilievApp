﻿using System;

namespace ForThreee
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = 10, k, s;
            Console.WriteLine("Сумма 1+3+5 +..+ {0}", 2 * n - 1);
            for (k = 1, s = 0; k <= n; s += 2 * k - 1, k++) ;
            Console.WriteLine(s);
        }
    }
}