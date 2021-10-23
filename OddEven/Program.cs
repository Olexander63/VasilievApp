using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Целочисленные переменные:
            int number, reminder;
            //Считывание целого числа:
            number = Int32.Parse(
               Interaction.InputBox("Введите целое число:",
                  "Проверка")
            );
            // Вычисляется остаток от деления на 2:
            reminder = number % 2;
            string txt = "Вы ввели ";
            // Использован тернарный оператор:
            txt += (reminder == 0 ? "четное" : "нечетное" + " число!");
            MessageBox.Show(txt);
        }
    }
}
