using System;

namespace AnotherTwoDimArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Символьный массив из переменных массива
            var symbs = new char[5][];
            //Целочисленный масив из переменных массива:
            int[][] nums = {new [] {1, 2, 3}, new [] {4, 5}, new [] {6, 7, 8, 9}};
            //Символьная переменная:
            var s = 'A';
            //Заполнение символьного массива.
            //Перебор элементов во внешнем массиве:
            for (var i = 0; i < symbs.Length; i++)
            {
                //Создание внутренего массива:
                symbs[i] = new char[i + 3];
                //Перебор єлементов во внутреннем массиве:
                for (var j = 0; j < symbs[i].Length; j++)
                {
                    //Значение єлемента внутреннего массива:
                    symbs[i][j] = s;
                    //Значение для следущего єлемента:
                    s++;
                }
            }

            Console.WriteLine("Целочисленный массив: ");
            //Отображение целочисленного массива:
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums[i].Length; j++)
                    //Отображение єлемента массива:
                    Console.Write("{0,3}", nums[i][j]);

                Console.WriteLine();
            }

            Console.WriteLine("Символьный массив:");
            //отображение символьного массива.
            //Перебор єлементов внешного массива:
            foreach (var q in symbs)
            {
                //Перебор элементов во внутреннем массиве:
                foreach (var p in q)
                    //Отображение єлемента массива:
                    Console.Write("{0,2}", p);

                Console.WriteLine();
            }
        }
    }
}