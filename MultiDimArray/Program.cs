using System;

namespace MultiDimArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Трехмерный символьный массив:
            var symbs = new char[4, 3, 5];
            //одномерный символьный массив:
            char[] s = {'б', 'Б', 'b', 'B'};
            //Заполение трехмерного массива и отображение значений его элементов.
            //Цикл по первому индексу:
            for (var i = 0; i < symbs.GetLength(0); i++)
            {
                //отображение сообщения:
                Console.WriteLine("Слой № {0}: ", i + 1);
                //Цикл по второму инедексу:
                for (var j = 0; j < symbs.GetLength(1); j++)
                {
                    //Цикл по третьему индексу:
                    for (var k = 0; k < symbs.GetLength(2); k++)
                    {
                        //Присваивание значения елементу массива:
                        symbs[i, j, k] = s[i];
                        //Изменение элемента в одномерном массиве:
                        s[i]++;
                        //Отображение значения элемента массива:
                        Console.Write(symbs[i, j, k] + " ");
                    }

                    //Переход к новой строке:
                    Console.WriteLine();
                }

                //Отображение "линии":
                Console.WriteLine("---------");
            }
        }
    }
}