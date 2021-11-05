using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherWhile
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Количество слогаемых в сумме и значение суммы:
            int n = 10, s = 0;
            //Отображение сообщения:
            Console.WriteLine("Сумма 1+3 + 5 +..+ {0} = ", 2 * n - 1);
            //Оператор цикла:
            while (n > 0)
            {
                s += 2 * n - 1; //Добавляем слогаемое в суммму
                n--; //Новое значение индексной переменной
            }

            // Отображение вычесленного значения:
            Console.WriteLine(s);
        }
    }
}