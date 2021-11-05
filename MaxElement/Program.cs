using System;

namespace MaxElement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Переменнныу для записи значения єлемента и индекса:
            int value, index;
            // Размер массива:
            var size = 15;
            //Обєкт для гнерирования случайных чисел:
            var rnd = new Random();
            //Создание массива:
            var nums = new int[size];
            //Заполнение и отображение массива:
            for (var k = 0; k < nums.Length; k++)
            {
                //Значение элемента массива:
                nums[k] = rnd.Next(1, 101);
                //Отображение значениия элемена:
                Console.WriteLine(nums[k] + " ");
            }

            Console.WriteLine();
            //Поиск наибольшего єлемента:
            index = 0; // начальное значение индекса
            value = nums[index]; //Значение элемента с индексом
            //Перебор элементов:
            for (var k = 1; k < nums.Length; k++)
                //Если значение проверяемого єлемента больше текущего наибольшего значение:
                if (nums[k] > value)
                {
                    value = nums[k]; //Новое наибольшое значение
                    index = k; // новое значение для индекса
                }

            //Отображение результата:
            Console.WriteLine("Наибольшее значение: " + value);
            Console.WriteLine("Индекс єлемента: " + index);
        }
    }
}