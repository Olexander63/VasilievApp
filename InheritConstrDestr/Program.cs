using System;

namespace InheritConstrDestr
{
    class Alpha
    {
        public Alpha()
        {
            Console.WriteLine("Конструкторклассса Alpha");
        }

        ~Alpha()
        {
            Console.WriteLine("Деструктор класса Alpha");
        }
    }

    class Bravo: Alpha
    {
        public Bravo() : base()
        {
            Console.WriteLine("Конструктор класа Bravo");
        }
    }

    class  Charlie: Bravo
    {
        public Charlie() : base()
        {
            Console.WriteLine("Конструктор класса Charlie");
        }

        ~Charlie()
        {
            Console.WriteLine("Деструктор класса Charlie");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            new Charlie();
        }
    }
}