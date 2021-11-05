using System;

namespace TwoDimArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Количество строк и столбцов в массиве:
            int rows = 3, cols = 5;
            // Создание двумерного массива:
            var nums = new int[rows, cols];
            // Значение первого элемента в массиве:
            var value = 1;
            // Заполнение и отображение массива.
            // Перебор строк в массиве:
            for (var i = 0; i < nums.GetLength(0); i++)
            {
                // Перебор столбцов в строке:
                for (var j = 0; j < nums.GetLength(1); j++)
                {
                    // Присваивание значения элементу массива:
                    nums[i, j] = value;
                    // Это будет значение следующего элемента:
                    value++;
                    // Отображение элемента в строке:
                    Console.Write(nums[i, j] + "\t");
                }

                // Переход к новой строке:
                Console.WriteLine();
            }
        }
    }
}