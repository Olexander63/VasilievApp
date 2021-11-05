using System;

namespace IntArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Создание массива из 12 чисел:
            var nums = new int[12];
            // Перебор элементов массива:
            for (var k = 0; k < nums.Length; k++)
            {
                // Присваивание значения элементу массива:
                nums[k] = 3 * k + 1;
                // Отображение значения элемента массива:
                Console.Write("| " + nums[k] + " ");
            }

            Console.WriteLine("|");
        }
    }
}