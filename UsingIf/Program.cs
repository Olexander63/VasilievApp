using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace UsingIf
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Переменая для оперделение типа пиктограмы;
            MessageBoxIcon icon;
            //Переменные для определения текста сообщений, заголовка окна и имени пользователя:
            string msg, title, name;
            name = Interaction.InputBox(
                //Тескт над полем ввода:
                "Как вас зовут?",
                "Знакомимся");
            //Проверка введенного пользователем текста
            if (name == "")
                //Пиктограмма ошибки:
            {
                icon = MessageBoxIcon.Error;
                //Текст соообщений:
                msg = "Очень жаль, что мы не познакомились!";
                //Заголовок окна;
                title = "Знакомство не состоялось";
            }
            else
            {
                //Если текст введен
                //Информационая  пиктограмма:
                icon = MessageBoxIcon.Information;
                //Текст сообщения:
                msg = "Очень приятно, " + name + "!";
                //Заголовок окна;
                title = "Знакомство состоялось";
            }

            // Отображение соообщения(аргументы - текст сообщения, заголовок, кнопки и пиктограмма):
            MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
        }
    }
}