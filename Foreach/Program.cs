using System;

namespace Foreach
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Целочисленный массив:
            int[] nums = {1, 3, 4, 8, 9};

            //Символьный массив:
            int[] symbs = {'a', 'b', 'c', 'A', 'B', 'C'};
            //Текстовый массив:

            string[] txts = {"красный", "желтый", "синий"};
            Console.WriteLine("Целочисленный массив");
            //Циклы по целочисленному массиву:
            foreach (var s in nums) Console.WriteLine("Число {0} - {1}", s, s % 2 == 0 ? "четное" : "нечетное");

            Console.WriteLine("Симольній массив");
            //Цикло по символьному массиву:
            foreach (char s in symbs) Console.WriteLine("Кл символа {0} - {1}", s, (int) s);

            Console.WriteLine("Текстовый массив");
            //Цикл по тектовому массиву:
            foreach (var s in txts) Console.WriteLine("В слово \"{0}\" {1} букв", s, s.Length);
        }
    }
}