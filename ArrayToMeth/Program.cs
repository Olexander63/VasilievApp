using System;

namespace ArrayToMeth
{
    public class Program
    {
        //Метод для щаполенния массива случайнымы числа:
        static void fillRand(int[] nums)
        {
            //обект для  генерирования случайных чисел:
            Random rnd = new Random();
            //Заполение массива случайными числами:
            for (int k = 0; k < nums.Length; k++)
            {
                nums[k] = rnd.Next(1, 101);
            }
        }
        //Метод для отображения одногомерного целочисленного масссива:
        static void showArray(int[] nums)
        {
            //Перебор элементов массива:
            for (int k = 0; k <nums.Length; k++)
            {
                //Отображение значения єлемента:
                Console.Write("|{0}", nums[k]);
            }

            Console.WriteLine("|");
        }
        //Метод для отображения двумерного целочисленного массива:
        static void showArray(int[,] nums)
        {
            //Перебор строк в массиве:
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    //отображение значения єлемента массива:
                    Console.Write("{0,3}", nums[i,j]);
                }
                //Переход к новой строке:
                Console.WriteLine();
            }
        }
        //Метод для вічисления нйименьшего єлемента в массиве:
        static int findMin(int[] nums)
        {
            //Локальная переменная:
            int s = nums[0];
            //Поиск наименьшегог значения:
            
            for (int k = 0; k < nums.Length; k++)
            {
                //Если проверяемый элемент имеет значение , меньше текущего значения переменной s:
                if (nums[k ]< s) s = nums[k];
            }
            //Результат метода:
            return s;
        }
        //Главный метод программы:
        public static void Main(string[] args)
        {
            //одномерные массивы:
            int[] A = {1,3,5,7,9,11,13,15};
            int[] B = new int[5];
            
            //Двумерный массив:
            int[,] C = {{ 1,2,3,4}, {5,6,7,8 }, {9,10,11,12 }};
            //Массив В заполеняется случайными числами:
            fillRand(B);
            Console.WriteLine("Одномерный массив A:");
            //Отображаеться массив A
            showArray(A);
            Console.WriteLine("Одномерный массив В:");
            showArray(B);
            //Поиск найименьшего елемента:

            int m = findMin(B);
            Console.WriteLine("Наимеьшее значение: {0}", m);
            Console.WriteLine("Двумерный массив С:");
            //Отображаеться массив С
            showArray(C);
                            
        }
    }
}