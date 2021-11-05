using System;

namespace NestedIf
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Текстовая переменная;
            string txt;
            //  Отображение сообщения:
            Console.WriteLine("Введите текст: ");
            //Считывание текстовой строки:
            txt = Console.ReadLine();
            //Если введена непустая строка:
            if (txt != "")
            {
                //Если в строке больше десяти символов:
                if (txt.Length > 10)
                    //Отображение сообщения:
                    Console.WriteLine("ого. как много букв!");
                //Если в строке не большедесяти символов:
                else
                    //Отображение сообщения:
                    Console.WriteLine("Ого, как мало букв!");
            }
            //Если введена пустая строка:
            else
            {
                Console.WriteLine("Жаль, что не ввели текст!");
            }
        }
    }
}