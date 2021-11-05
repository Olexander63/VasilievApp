using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Hundreds
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Целочисленные переменные:
            int number, hundreads;
            //Считывание целого числа:
            number = int.Parse(
                Interaction.InputBox(
                    // Надпись над полем ввода:
                    "Введите целое число:",
                    // Заголовок окна:
                    "Количество сотен"));

            // Количество сотен в числе (для целочисленных
            // операндов деление выполняется нацело):
            hundreads = number / 100 % 10;
            // Текстовая переменная:
            var txt = "В этом числе " + hundreads + " сотен!";
            // Отображение окна с сообщением
            //(аргументы метода - сообщение и заголовок окна):
            MessageBox.Show(txt, "Сотни");
        }
    }
}