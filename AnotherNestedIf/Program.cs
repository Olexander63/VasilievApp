using System;

namespace AnotherNestedIf
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Переменная для запоминания введенного числа:

            int number;
            // Отображение сообщения:
            Console.WriteLine("Введите целое число:");
            // Считывание числа:
            number = int.Parse(Console.ReadLine());
            //Если введена единаца:
            if (number == 1) Console.WriteLine("Единица");
            //Если введена двойка:
            else if (number == 2) Console.WriteLine("Двойка");
            // Если введена тройка:
            else if (number == 3) Console.WriteLine("Тройка");
            //Если введена четверка:
            else if (number == 4) Console.WriteLine("Четверка");
            //Все  прочие случаии:
            else Console.WriteLine("Неизвестное число");
        }
    }
}