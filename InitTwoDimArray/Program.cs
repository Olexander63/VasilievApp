using System;

namespace InitTwoDimArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Создание и инициализация двумерного массива:
            char[,] symbs = {{'A', 'B', 'C'}, {'D', 'E', 'F'}};
            Console.WriteLine("Исходный массив:");
            //отображение массива:

            for (var i = 0; i < symbs.GetLength(0); i++)
            {
                for (var j = 0; j < symbs.GetLength(1); j++)
                    //Отображение  значения элемента:
                    Console.Write(symbs[i, j] + " ");
                //Переходи к новой строке:
                Console.WriteLine();
            }

            //Обьект для генерирования случайных чисел:
            var rnd = new Random();
            //Строка и столбец:
            var row = rnd.Next(symbs.GetLength(0) + 1);
            var col = rnd.Next(symbs.GetLength(1) + 1);
            Console.WriteLine("Добавляється {0} -я строка и {1}-й столбец", row, col);
            //Создание нового массива:
            var tmp = new char[symbs.GetLength(0) + 1, symbs.GetLength(1) + 1];
            //Целочислные переменные:
            int a, b;
            //Симольная  переменнная:
            var s = 'a';
            //Заоплнение массиваюКопирование значений из исходного массива:
            for (var i = 0; i < symbs.GetLength(0); i++)
            {
                // Первый индекс для элемента нового массива:
                if (i < row) a = i;
                else a = i + 1;
                for (var j = 0; j < symbs.GetLength(1); j++)
                {
                    //Второй индекс для элемента ного массива:
                    if (j < col) b = j;
                    else b = j + 1;
                    // Присваивание значения элементу массива:
                    tmp[a, b] = symbs[i, j];
                }
            }

            // Заполнение добавленной строки в новом массиве:
            for (var j = 0; j < tmp.GetLength(1); j++)
            {
                // Значение элемента в строке:
                tmp[row, j] = s;
                //Новое значение для следущегого элемента:
                s++;
            }

            for (var i = 0; i < tmp.GetLength(0); i++)
                // Если элемент не в добавленной строке:
                if (i != row)
                {
                    // Значение элемента в столбце:
                    tmp[i, col] = s;
                    // Новое значение для следующего элемента:
                    s++;
                }

            // Присваивание массивов:
            symbs = tmp;
            Console.WriteLine("Новый массив:");
            //Отображение массива:
            for (var i = 0; i < symbs.GetLength(0); i++)
            {
                for (var j = 0; j < symbs.GetLength(1); j++)
                    // Отображение значения элемента:
                    Console.Write(symbs[i, j] + " ");
                //Переходи к новой строке:
                Console.WriteLine();
            }
        }
    }
}