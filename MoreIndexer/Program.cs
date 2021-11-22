using System;

namespace MoreIndexer
{
    class MyClass
    {
        private int code;

        public MyClass(char s)
        {
            code = s;
        }

        public char this[int k]
        {
            get
            {
                return (char) (code + k);
            }

            set
            {
                code = value - k;
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass('A');
            for (int k = 0; k < 10; k++)
            {
                Console.Write(obj[k]+ " ");
            }

            Console.WriteLine();
            obj[5] = 'Q';
            for (int k = 0; k < 10; k++)
            {
                Console.Write(obj[k]+" ");
            }

            Console.WriteLine();
            for (int k = 0; k < 10; k++)
            {
                Console.Write(obj[-k]+" ");
            }

            Console.WriteLine();
        }
    }
}