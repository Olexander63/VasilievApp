using System;

namespace ArrayInStruct
{
    struct MyStruct
    {
        public  char[] symbs;

        public void show()
        {
            for (int k = 0; k < symbs.Length; k++)
            {
                Console.Write("|"+ symbs[k]);
            }

            Console.WriteLine("|");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            MyStruct A, B;
            A.symbs = new char[7];
            for (int k = 0; k < A.symbs.Length; k++)
            {
                A.symbs[k] = (char)
                ('A' + k);
            }

            Console.WriteLine("Экземпляр А:");
            A.show();
            B = A;
            Console.WriteLine("Экземпляр B:");
            B.show();
            A.symbs[0] = 'X';
            B.symbs[B.symbs.Length - 1] = 'Y';
            Console.WriteLine("Экземпляр A:");
            A.show();
            Console.WriteLine("Экзепляр B:");
            B.show();
        }
    }
}