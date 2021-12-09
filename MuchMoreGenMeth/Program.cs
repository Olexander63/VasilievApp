using System;

namespace MuchMoreGenMeth
{
    internal class Program
    {
        static void show<T>(T[] array)
        {
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write("|" + array[k]);
            }

            Console.WriteLine("|");
        }

        static T[] create<T>(int n)
        {
            T[] array = new T[n];
            return array;
        }

        static void fill<T>(T[] a, T b)
        {
            for (int k = 0; k < a.Length; k++)
            {
                a[k] = b;
            }
        }

        static T getRand<T>(T[] a, Random rnd)
        {
            return a[rnd.Next(a.Length)];
        }
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] A = {"one", "two", "three"};
            int[] B = {2, 3, 5, 8, 13, 21};
            char[] C = {'c', 'h', 'a', 'r', 'l', 'i'};
            show(A);
            show(B);
            Console.WriteLine("Случайные числа:");
            for (int k = 1; k <=10 ; k++)
            {
                Console.Write(getRand(B,rnd)+" ");
            }

            Console.WriteLine();
            show(C);
            Console.WriteLine("Случайные символы:");
            for (int k = 1; k <=10; k++)
            {
                Console.Write(getRand(C,rnd)+" ");
            }

            Console.WriteLine();
            char[] symbs = create<char>(6);
            fill(symbs,'W');
            show(symbs);
            int[] nums = create<int>(7);
            fill(nums,3);
            show(nums);
        }
    }
}