using System;

namespace DoWhile
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Количество слогаемых в  сумме, индексная переменная и значение суммы:
            int n = 10, k = 1, s = 0;

            //Отображение сообщения:
            Console.WriteLine("Сумма 1 + 3 + 5 +..+ {0}", 2 * n - 1);
            //Оператор цикла:
            do
            {
                s += 2 * k - 1; //Добавляем слогаемое в сумму
                k++; //Новое значение индексной переменной
            } while (k <= n);

            //Отображение вычисленного значения:
            Console.WriteLine(s);
        }
    }
}