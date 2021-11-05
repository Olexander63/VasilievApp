﻿using System;

namespace Args
{
    internal class Program
    {   
        // Первый метод. Аргумент - целое число:
        static void alpha(int n){
            // Проверка значения аргумента:
            Console.WriteLine("В методе alpha(). На входе: "+n);
            // Попытка изменить значение аргумента:
            n++;
            // Проверка значения аргумента:
            Console.WriteLine("В методе alpha(). На выходе: "+n);
        }
        // Второй метод. Аргумент - ссылка на массив:
        static void bravo(int[] n){
            // Проверка содержимого массива:
            Console.WriteLine("В методе bravo(). На входе: "+ArrayToText(n));
            // Перебор элементов массива:
            for(int k=0;k<n.Length;k++){
                // Попытка изменить значение элемента массива:
                n[k]++;
            }
            // Проверка содержимого массива:
            Console.WriteLine("В методе bravo(). На выходе: "+ArrayToText(n));
        }
        // Третий метод. Аргумент - ссылка на массив:
        static void charlie(int[] n){
            // Проверка содержимого массива:
            Console.WriteLine("В методе charlie(). На входе: "+ArrayToText(n));
            // Создается новый массив:
            int[] m=new int[n.Length];
            // Перебор элементов в массиве:
            for(int k=0;k<n.Length;k++){
                // Значение элемента массива:
                m[k]=n[k]+1;
            }
            // Попытка присвоить новое значение аргументу:
            n=m;
            // Проверка содержимого массива:
            Console.WriteLine("В методе charlie(). На выходе: "+ArrayToText(n));
        }
        // Метод для преобразования массива в текст:
        static string ArrayToText(int[] n){
            // Текстовая переменная:
            string res="["+n[0];
            // Перебор элементов массива (кроме начального):
            for(int k=1;k<n.Length;k++){
                // Дописывание текста в текстовую переменную:
                res+=","+n[k];
            }
            // Дописывание текста в текстовую переменную:
            res+="]";
            // Результат метода - текстовая строка:
            return res;
        }
        public static void Main(string[] args)
        {
            
            // Переменная для передачи аргументом методу:
            int A=100;
            // Проверка значения переменной:
            Console.WriteLine("До вызова метода alpha(): A="+A);
            // Вызов метода:
            alpha(A);
            // Проверка значения переменной:
            Console.WriteLine("После вызова метода alpha: A="+A);
            // Массив для передачи аргументом методу:
            int[] B={1,3,5};
            // Проверка содержимого массива:
            Console.WriteLine("До вызова метода bravo(): B="+ArrayToText(B));
            // Вызов метода:
            bravo(B);
            // Проверка содержимого массива:
            Console.WriteLine("После вызова метода bravo(): B="+ArrayToText(B));
            // Массив для передачи аргументом методу:
            int[] C={2,4,6};
            // Проверка содержимого массива:
            Console.WriteLine("До вызова метода charlie(): C="+ArrayToText(C));
            // Вызов метода:
            charlie(C);
            // Проверка содержимого массива:
            Console.WriteLine("После вызова метода charlie(): C="+ArrayToText(C));


        }
    }
}