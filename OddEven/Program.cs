using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace OddEven
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Целочисленные переменные:
            int number, reminder;
            //Считывание целого числа:
            number = int.Parse(
                Interaction.InputBox("Введите целое число:",
                    "Проверка")
            );
            // Вычисляется остаток от деления на 2:
            reminder = number % 2;
            var txt = "Вы ввели ";
            // Использован тернарный оператор:
            txt += reminder == 0 ? "четное" : "нечетное" + " число!";
            MessageBox.Show(txt);
        }
    }
}