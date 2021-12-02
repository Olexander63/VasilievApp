using System;

namespace LambdaAsResult
{
    delegate int MyDelegate();

    class LambdaAsResultDemo
    {
        static MyDelegate calculate(int n)
        {
            int cont = 0;
            return () =>
            {
                cont += n;
                return cont;
            };
        }
        public static void Main(string[] args)
        {
            MyDelegate next = calculate(1);
            for (int i = 1; i <=5; i++)
            {
                Console.Write(next()+" ");
            }

            Console.WriteLine();
            next = calculate(3);
            for (int i = 1; i <=5; i++)
            {
                Console.Write(next()+" ");
            }

            Console.WriteLine();
        }
    }
}