using System;

namespace ObjectArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {   //Массив их трех переменных тпа Oject:
            object[] objects = new  Object[3];
            //Єлементам массива присваиваються значения
            //разных тивов:
            objects[0] = 123; // Целое число
            objects[1] = 'A';   //Символ
            objects[2] = "Третий єлемент";  //Текст
            Console.WriteLine("Создан такой массив:");
            //Проверка содержимого массива:
            for (int k = 0; k < objects.Length; k++)
            {
                Console.WriteLine(k+ ": " + objects[k]);
            }
            //новое значение єлементов:
            objects[0] = (int) objects[0] + 111;    //Целое число
            objects[1] = "Второй елемент";  //текст
            objects[2] = 3.141592;  //Действительное число
            Console.WriteLine("");
            //Проверка содержимого массива:
            for (int k = 0; k < objects.Length; k++)
            {
                Console.WriteLine(k+": " +objects[k]);
            }
            //Целочисленный массив:
            int[] nums = {10, 20, 30};
            //Переменная массива присваеться как значение элемента масссива
            objects[2] = nums;
            Console.WriteLine("Целочисленный массив:");
            //Отображеие элементов целочисленного массива:
            for (int i = 0; i <((int[])objects[2]).Length; i++)
            {
                Console.Write("{0,3}",((int[])objects[2])[i]);
            }

            Console.WriteLine();
            //Новое значение элемента в числовом массиве:
            ((int[]) objects[2])[1] = 0;
            Console.WriteLine("Еще раз тот же массив:");
            //отображение элементов целочисленноо массива:
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0,3}",nums[i]);
            }

            Console.WriteLine();
        }
    }
}