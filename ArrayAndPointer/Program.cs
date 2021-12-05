using System;

namespace ArrayAndPointer
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int size = 10;
            int* q;
            int[] nums = new int[size];
            Console.WriteLine("Заполение массива: ");
            fixed (int* p = nums)
            {
                q = p + size - 1;
                for (int k = 0; k < nums.Length; k++)
                {
                    p[k] = k + 1;
                    Console.Write("|"+ nums[k]);
                }

                Console.WriteLine("|");
                while (p<=q)
                {
                    (*q) *= (*q);
                    q--;
                }
            }

            Console.WriteLine("Массив после изменения: ");
            for (int k = 0; k < nums.Length; k++)
            {
                Console.Write("|"+nums[k]);
            }

            Console.WriteLine("|");
        }
    }
}