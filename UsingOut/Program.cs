using System;

namespace UsingOut
{
    internal class Program
    {   
        //Метод для вычисления значения найименьшого элемента в массиве и его индекса:
        static int getMin(int[] nums, out int index)
        {
            // Начальное значение для индекса:
            index=0;
            // Перебор элементов массива:
            for(int k=1;k<nums.Length;k++){
                // Если значение элемента массива меньше текущего
                // минимального значения:
                if(nums[k]<nums[index]){
                    // Новое значение для индекса:
                    index=k;
                }
            }
            // Результат метода:
            return nums[index];
        }
        //Главный метод программы:
        public static void Main(string[] args)
        {
            // Целочисленный массив:
            int[] A={12,7,8,3,8,4,1,3,4,1,7,15};
            // Отображение содержимого массива:
            foreach(int v in A){
                Console.Write("| {0} ",v);
            }
            Console.WriteLine("|");
            // Объявление переменных:
            int val,k;
            // Вычисление элемента с наименьшим значением:
            val=getMin(A,out k);
            // Отображение результатов:
            Console.WriteLine("Наименьшее значение: "+val);
            Console.WriteLine("Индекс элемента: "+k);
            Console.WriteLine("Проверка: A[{0}]={1}",k,A[k]);
        }
    }
}