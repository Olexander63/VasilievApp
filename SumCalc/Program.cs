using System;
using System.Threading;

namespace SumCalc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double s = 0;
            Console.WriteLine("Вычисление суммы");
            Console.WriteLine("Контрольное щначение: {0}",2*Math.E);
            Thread calc = new Thread(() =>
            {
                int n = 1;
                double q = 1;
                do
                {
                    s += q;
                    n++;
                    q = n * n;
                    for (int k = 1; k <=n ; k++)
                    {
                        q /= k;
                    }
                    Thread.Sleep(100);
                } while (true);
            });
            calc.Start();
            Thread.Sleep(1000);
            calc.Abort();
            Console.WriteLine("Вычисление значение:{0}",s);
        }
    }
}