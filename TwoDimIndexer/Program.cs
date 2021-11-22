using System;

namespace TwoDimIndexer
{
    class MyClass
    {
        private char[,] symbs;

        public MyClass(int a, int b)
        {
            symbs = new char[a, b];
            for (int i = 0; i < symbs.GetLength(0); i++)
            {
                for (int j = 0; j< symbs.GetLength(1); j++)
                {
                    symbs[i, j] = '0';
                }
            }
        }

        public void show()
        {
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < symbs.GetLength(0); i++)
            {
                for (int j = 0; j < symbs.GetLength(1); j++)
                {
                    Console.Write(symbs[i,j]+" ");
                }

            }
            Console.WriteLine();

        }

        public char this[int i, int j]
        {
            get
            {
                return symbs[i, j];
            }
            set
            {
                symbs[i, j] = value;
            }
        }
        
    }
    class Program
    {
        public static void Main()
        {
            MyClass obj = new MyClass(2, 3);
            obj.show();
            obj[0, 0] = 'A';
            obj[1, 2] = 'Z';
            obj.show();
            Console.WriteLine(" Проверка: ");
            Console.WriteLine("obj[0,0]={0}", obj[0,0]);
            Console.WriteLine("obj[1,1]={0}", obj[1,1]);
            Console.WriteLine("obj[1,2]={0}",obj[1,2]);

        }
    }
}