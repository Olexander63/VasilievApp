using System;

namespace StaticProps
{
    class Fibs
    {
        private static int last = 1;
        private static int prev = 1;

        public static int number
        {
            get
            {
                int res = prev;
                last = last + prev;
                prev = last - prev;
                return res;
            }
            set
            {
                prev = 1;
                last = 1;
                for (int k = 2; k <=value; k++)
                {
                    last = last + prev;
                    prev = last - prev;
                }
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // Отображение значения статического свойства:
            for(int k=1;k<=10;k++){
                Console.Write("{0,4}",Fibs.number);
            }
            Console.WriteLine();
            // Присваивание значения статическому свойству:
            Fibs.number=6;
            // Отображение значения статического свойства:
            for(int k=1;k<=10;k++){
                Console.Write("{0,4}",Fibs.number);
            }
            Console.WriteLine();
            // Присваивание значения статическому свойству:
            Fibs.number=1;
            // Отображение значения статического свойства:
            for(int k=1;k<=10;k++){
                Console.Write("{0,4}",Fibs.number);
            }
            Console.WriteLine();
        }
    }
}