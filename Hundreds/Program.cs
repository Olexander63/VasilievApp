using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundreds
{
    class Program
    {
        static void Main(string[] args)
        {
            // Целочисленные переменные:
            int number, hundreads;
            //Считывание целого числа:
            number = Int32.Parse(
                Interaction.InputBox(
            // Надпись над полем ввода:
            "Введите целое число:",
            // Заголовок окна:
            "Количество сотен"));

            // Количество сотен в числе (для целочисленных
            // операндов деление выполняется нацело):
            hundreads = number / 100 % 10;
            // Текстовая переменная:
            string txt = "В этом числе " + hundreads + " сотен!";
            // Отображение окна с сообщением
            //(аргументы метода - сообщение и заголовок окна):
            MessageBox.Show(txt, "Сотни");
        }
    }
}
