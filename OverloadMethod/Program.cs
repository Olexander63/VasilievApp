﻿using System;

namespace OverloadMethod
{
    public class Program
    {
        //Версия статического метода для отображения текста
        //(с одним тектовым аргументом)
        static void show(string txt)
        {
            Console.WriteLine("Текст: " + txt);
        }
        //Версия статического метода для отображения целого числа( аргументо метода)
        static void show(int num)
        {
            Console.WriteLine("Целое число:" + num);
        }
        //Версия статического метода для отображения действительоного числа(аргументом метода):
        static void show(double num)
        {
            Console.WriteLine("Действительное число: " + num);
        }
        //Версия статического метода для отображения символа(аргументо метода):
        static void show(char s)
        {
            Console.WriteLine("Символ: "+s);
        }
        //Весрия статического метода для отображения числа ( первый аргумент) и символа(второй аргумент):
        static void show(int num, char s)
        {
            Console.WriteLine("Аргумент {0} и {1}", num, s);
        }
        public static void Main(string[] args)
        {
            //Целочисленная переменная:
            int num = 5;
            
            //Действильное числовая переменная
            double z = 12.5;
            //Симольная переменная:
            char symb = 'W';
            //Вызываем метод с символьным аргументом:
            show(symb);
            //Вызываем метод с текстовым аргументом:
            show("Знакомимся с перегрузкой  методов");
            //Вызываем метод с целочисленным аргументом
            show(num);
            //Вызываем метод с действительным аргументом:
            show(z);
            //Вызываем метод двумя аргументами
            show(num,'Q');
        }


    }
}