using System;

namespace Recursion
{
    internal class Program
    {
        // Метод для вычисления факториала числа:
        static int factorial(int n){
            if(n==1) return 1;
            return n*factorial(n-1);
        }
        // Метод для вычисления чисел Фибоначчи:
        static int fibs(int n){
            if(n==1||n==2) return 1;
            return fibs(n-1)+fibs(n-2);
        }
        // Метод для вычисления суммы чисел:
        static int sum(int n){
            if(n==0) return 0;
            return n+sum(n-1);
        }
        // Метод для отображения содержимого массива:
        static void show(int[] a,int k){
            // Отображение значения элемента массива:
            Console.Write(a[k]+" ");
            // Если элемент в массиве последний:
            if(k==a.Length-1){
                Console.WriteLine();
            }
            // Если элемент в массиве не последний:
            else{
                // Рекурсивный вызов метода:
                show(a,k+1);
            }
        }
        // Перегрузка метода для отображения
        // содержимого массива:
        static void show(int[] a){
            // Вызов версии метода с двумя аргументами:
            show(a,0);
        }
        //Главный метода программы:
        public static void Main()
        {
            Console.WriteLine("Факториал числа:");
            for(int k=1;k<=10;k++){
                // Вычисление факториала числа:
                Console.WriteLine(k+"!="+factorial(k));
            }
            Console.WriteLine("Числа Фибоначчи:");
            for(int k=1;k<=10;k++){
                // Вычисление чисел Фибоначчи:
                Console.Write(fibs(k)+" ");
            }
            Console.WriteLine();
            Console.Write("Сумма чисел от 1 до 100: ");
            Console.WriteLine(sum(100));
            // Числовой массив:
            int[] A={1,3,5,7,9,11,13,15,17,19,21};
            Console.WriteLine("Числовой массив:");
            // Отображение всех элементов массива:
            show(A);
            Console.WriteLine("Элементы, начиная с третьего:");
            // Отображение элементов, начиная с третьего:
            show(A,2);
        }
    }
}