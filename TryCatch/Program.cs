using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace TryCatch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Сообзение о начале выполнение программмы:
            MessageBox.Show("Выполняется программа!", "Начало");
            //Перехват и обработка исключенний:
            try
            {
                //Контролируемый код
                //Попытка преобразовать текст в число:
                double.Parse(
                    Interaction.InputBox(
                        //Текст на полем ввода:
                        "Введите действительное число:",
                        //Заголовок:
                        "Число")
                );
                // отображение сообщения:
                MessageBox.Show("Да, это было число!", "Число");
            }
            catch
            {
                //отображение сообзения:
                MessageBox.Show(
                    //Текс сообщение:
                    "Надо было ввести число",
                    //Заголовок окна:
                    "Ошибка",
                    //В окне одна кнопка  ОК:
                    MessageBoxButtons.OK,
                    //Используеться пиктограмма ошибки:
                    MessageBoxIcon.Error
                );
            } //Завершение блока обработки исключений

            //Соббщение о завершении выполнения программмы:
            MessageBox.Show("Программа завершена!", "Завершение");
        }
    }
}