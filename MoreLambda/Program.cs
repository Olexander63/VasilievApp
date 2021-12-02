using System;

namespace MoreLambda
{
    class MyClass
    {
        private string text;

        public MyClass(string t)
        {
            text = t;
        }

        public char this[int k] => text[k];
        public int length => text.Length;
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass("Alpha");
            for (int k = 0; k < obj.length; k++)
            {
                Console.Write("|"+ obj[k]);
            }

            Console.WriteLine("|");
        }
    }
}