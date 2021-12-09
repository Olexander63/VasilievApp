using System;
using System.Runtime.InteropServices;

namespace GenMethOverload
{
    internal class Program
    {
        static void show<T>(T a)
        {
            Console.WriteLine("Версия №1");
            Console.WriteLine("Аргумент: {0}",a);
        }

        static void show(int a)
        {
            Console.WriteLine("Версия №2");
            Console.WriteLine("Число: {0}",a);
        }

        static void show<T, U>(T a, U b)
        {
            Console.WriteLine("Версия №3");
            Console.WriteLine("Первый: {0}",a);
            Console.WriteLine("Второй: {0}",b);
        }

        static void show<T>(T a, int b)
        {
            Console.WriteLine("Версия №4");
            Console.WriteLine("Первый: {0}",a);
            Console.WriteLine("Число: {0}",b);
        }
        public static void Main(string[] args)
        {
            show('A');
            show(123);
            show<int>('A');
            show<int>(123);
            show("B","Bravo");
            show('C',321);
            show<char,int>('C',321);
        }
    }
}