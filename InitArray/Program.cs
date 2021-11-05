using System;

namespace InitArray
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = {1, 3, 5, 7, 6, 5, 5};
            var symbs = new[] {'A', 'Z', 'B', 'Y'};
            var txts = new string[3] {"один", "два", "три"};
            //Отображение содержимого массивов:
            Console.WriteLine("Массив nums");
            for (var k = 0; k < nums.Length; k++) Console.Write(nums[k] + "");

            Console.WriteLine("\n Массив symbs: ");
            for (var k = 0; k < symbs.Length; k++) Console.Write(symbs[k] + " ");

            Console.WriteLine("\n Массив txts:");
            for (var k = 0; k < txts.Length; k++) Console.Write(txts[k] + " ");

            Console.WriteLine();
        }
    }
}