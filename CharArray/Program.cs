using System;

namespace CharArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Обєк для генерирования случайніх чисел:
            var rnd = new Random();
            //Размер массива и индексная переменнная:
            int size = 10, k;
            //Создание символьнго массива:
            var symbs = new char[size];
            //Отображение сообщения:
            Console.WriteLine("Массив случайных символов:");
            //Заполнение элемента масива:
            for (k = 0; k < symbs.Length; k++)
            {
                symbs[k] = (char) ('A' + rnd.Next(26));
                //Отображение значения элемента массива:
                Console.Write("|" + symbs[k] + "");
            }

            Console.WriteLine("|");

            //Отображение сообщения:
            Console.WriteLine("Массив в  обратном порядке: ");
            for (k = symbs.Length - 1; k >= 0; k--)
                //отображение значения для элемента массива:
                Console.Write("| " + symbs[k] + " ");

            Console.WriteLine("|");
        }
    }
}