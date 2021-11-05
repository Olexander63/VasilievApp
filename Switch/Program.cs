using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Switch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Переменая для запоминания  введденого числа:
            int number;
            //Переменная для записи названия числа:
            string name;
            //Считывание числа:
            number = int.Parse(
                Interaction.InputBox(
                    //текст над полем ввода:
                    "Введите число: ",
                    //Заголовок окна:
                    "Число")
            );

            //Использование оператора выбора для определения названия введеного чилса:
            switch (number)
            {
                case 1:
                    name = "Единица";
                    break;
                case 2:
                    name = "Двойка";
                    break;
                case 3:
                    name = "Тройка";
                    break;
                case 4:
                    name = "Четверка";
                    break;
                default:
                    name = " Неизвестное число";
                    break;
            }

            //Отображение сообщения:
            MessageBox.Show(name, "Число");
        }
    }
}