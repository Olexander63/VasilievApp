using System;

namespace Fixed
{
    class MyClass
    {
        public int number;

        public MyClass(int n)
        {
            number = n;
        }

        ~MyClass()
        {
            Console.WriteLine("Удален обьект с полем "+number);
        }
    }
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            fixed (int* p = &new MyClass(123).number)
            {
                Console.WriteLine("Значение поля number: " + *p);
                *p = 321;
                Console.WriteLine("Завершение fixed - блока");

            }
        }
    }
}