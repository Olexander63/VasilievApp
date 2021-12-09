using System;

namespace MoreGenMeth
{
    internal class Program
    {
        static void show<T, U>(T a, U b)
        {
            Console.WriteLine("Первый аргумент {0}",a);
            Console.WriteLine("Второй аргумент {0}",b);
        }
        public static void Main(string[] args)
        {
            show(100,'A');
            show('B',"Bravo");
            show('C','D');
            show<int,char>('C','D');
        }
    }
}