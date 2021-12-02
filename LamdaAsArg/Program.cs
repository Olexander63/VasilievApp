using System;

namespace LamdaAsArg
{
    delegate char MyDelegate(int n);

    class MyClass
    {
        public char symbol;
        public MyDelegate get;

        public MyClass(char s, MyDelegate md)
        {
            symbol = s;
            get = md;
        }

        public void set(MyDelegate md)
        {
            get = md;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass('K', n => (char) ('A' + n));
            Console.WriteLine("Символ: \'{0}\'",obj.get(3));
            obj.set(n=>(char)(obj.symbol + n));
            Console.WriteLine("Символ: \'{0}\'",obj.get(3));
        }
    }
}