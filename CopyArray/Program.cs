using System;

namespace CopyArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Целочисленный масив:
            int[] A = {1, 3, 5, 7, 9};
            //Переменные массива
            int[] B, C;
            //Присваевание  массива;
            B = A;
            //Создание ногвого массива:
            C = new int[A.Length];
            //Поэлементное копирование массива:
            for (var k = 0; k < A.Length; k++) C[k] = A[k];
            // Изменение значения первого элемента в массиве А:
            A[0] = 0;
            //Изменение значения последного элемента в массиве В:
            B[B.Length - 1] = 0;
            Console.WriteLine("A:\tB:\tC:");
            //отображение содержимого в массивов:
            for (var k = 0; k < A.Length; k++)
                //Отображение значений єлемента массивов:
                Console.WriteLine("{0}\t{1}\t{2}", A[k], B[k], C[k]);
        }
    }
}