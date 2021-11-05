using System;

namespace Goto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Переменнные: количество слогаумых, индексная переменная и значение суммы:
            int n = 10, k = 1, s = 0;
            //Отображение сообщения;
            Console.WriteLine("Сумма 1 +3 + 5 +..+ {0} = ", 2 * n - 1);
            //Испльзование метки:
            mylabel:
            //Добавление слогаемоу в сумму:
            s += 2 * k - 1;
            //Измениние значение индексной переменной:
            k++;

            //Использование инструкции goto:

            if (k <= n) goto mylabel;
            //отображение результата вычислений:
            Console.WriteLine(s);
        }
    }
}