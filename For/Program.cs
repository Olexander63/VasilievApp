using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Количество слагаемыв в сумме, индексная переменна и значение суммы:
            int n = 10, k, s = 0;
            //отображение сообщения:
            Console.WriteLine("Сумма 1 +3 +5 +..+ {0} = ", 2 * n - 1);
            //Оператора цикла:
            for (k = 1; k <= n; k++) s += 2 * k - 1;
            //отображение вычисленного значения:
            Console.WriteLine(s);
        }
    }
}