using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Количество слогаемых в сумме, индексная переменная и щначение суммы:
            int n = 10, k = 1, s = 0;
            //Отображение сообщения:
            Console.WriteLine("Сумма 1+3 + 5 +..+ {0} = ", 2 * n - 1);
            //Оператор цикла:
            while (k <= n)
            {
                s += 2 * k - 1; //Добавляем слогаемое в суммму
                k++; //Новое значение индексной переменной
            }

            // Отображение вычесленного значения:
            Console.WriteLine(s);
        }
    }
}