using System;

namespace WithoutSetIndexer
{
    class MyClass
    {
        private int number;

        public MyClass(int n)
        {
            number = n;
        }

        public int this[int k]
        {
            get
            {
                int n = number;
                for (int i = 1; i <k; i++)
                {
                    n /= 10;
                }

                return n % 10;
            }
        }
    }
  
     class Program
    {
        
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass(12345);
            for (int k = 1; k < 9; k++)
            {
                Console.Write(" | " + obj[k]);
            }

            Console.WriteLine(" |");
        }
    }
}