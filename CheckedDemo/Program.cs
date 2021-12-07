using System;

namespace CheckedDemo
{
    class MyClass
    {
        private byte num;

        public int number
        {
            get
            {
                return num;
            }
            set
            {
                try
                {
                    checked
                    {
                        num = (byte) value;
                    }
                }
                catch (OverflowException)
                {
                    num = 255;
                }
            }
        }

    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.number = 100;
            Console.WriteLine("Значение свойства: "+ obj.number);
            obj.number = 300;
            Console.WriteLine("Значение свойства: "+ obj.number);
        }
    }
}