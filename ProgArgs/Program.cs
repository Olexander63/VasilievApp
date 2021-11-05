﻿using System;

namespace ProgArgs
{
    public class Program
    {
        //Главный метод с аргументом -- массивом:
        public static void Main(string[] args)
        {
            // Определение количества переданных параметров:
            Console.WriteLine("Передано {0} параметров",args.Length);
            // Отображение значений параметров:
            for(int k=0;k<args.Length;k++){
                // Отображение значения параметра:
                Console.WriteLine("{0}-й параметр: {1}",(k+1),args[k]);
            }
            Console.WriteLine("Выполнение программы завершено");
            
        }
    }
}