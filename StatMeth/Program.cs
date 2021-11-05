﻿using System;

namespace StatMeth
{

    public class Program
    {
        // Статический метод для отображения текста,
        // переданного аргументом методу:
        static void show(string txt){
            Console.WriteLine(txt);
        }
        // Статический метод для вычисления факториала числа,
        // переданного аргументом методу:
        static int factorial(int n){
            // Локальная переменная:
            int s=1;
            // Вычисление произведения:
            for(int k=1;k<=n;k++){
                // Умножение произведения на число:
                s*=k;
            }
            // Результат метода:
            return s;
        }
        // Статический метод для возведения числа в степень.
        // Число и степень передаются аргументами методу:
        static double power(double x,int n){
            // Локальная переменная:
            double s=1;
            // Вычисление результата (число в степени):
            for(int k=1;k<=n;k++){
                // Текущее значение умножается на число:
                s*=x;
            }
            // Результат метода:
            return s;
        }
        // Главный метод программы:
        static void Main(){
            // Вызываем статический метод для отображения
            // сообщения в консольном окне:
            show("Начинаем вычисления:");
            int m=5;        // Целочисленные переменные
            double z=3,num; // Действительные переменные
            // Вычисление факториала числа:
            show(m+"!="+factorial(m));
            // Число в степени:
            num=power(z,m);
            // Отображение сообщения вызовом статического метода:
            show(z+" в степени "+m+": "+num);
        }
    }
}