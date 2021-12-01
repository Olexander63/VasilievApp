using System;

namespace AnonymAsResult
{
    delegate int MyDelegate();

    class AnonymAsResult
    {
        private static MyDelegate calculate(int n)
        {
            int count = 0;
            return delegate
            {
                count += n;
                return count;
            };
        }
        
        public static void Main()
        {
            MyDelegate next = calculate(1);
            for (int i = 1; i <=5; i++)
            {
                Console.Write(next() +" ");
            }

            Console.WriteLine();
            next = calculate(3);
            for (int i = 1; i <=5; i++)
            {
                Console.Write(next() +" ");
            }

            Console.WriteLine();
        }
    }

}