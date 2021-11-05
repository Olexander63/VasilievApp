using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace AnotherIf
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Пиктограмма (сначала это пиктограмма ошибки):
            var icon = MessageBoxIcon.Error;
            // Текст сообщения:
            string msg = "Очень жаль, что мы не познакомились!",
                //Заголовок окна:
                title = "Знакомство не состоялось",
                // Переменная для записи имени пользователя:
                name;
            // Отображение окна с полем ввода:
            name = Interaction.InputBox(
                // Текст над полем ввода:
                "Как Вас зовут?",
                // Заголовок окна:
                "Знакомимся");
            // Условный оператор в упрощенной форме:
            if (name != "")
            {
                /// Eсли не пустая текстовая строка
                // Новый тип пиктограммы:
                icon = MessageBoxIcon.Information;
                // Новый текст сообщения:
                msg = "Очень приятно, " + name + "!";
                // Новый заголовок окна:
                title = "Знакомство состоялось";
            } // Завершение условного оператора

            // Отображение окна с сообщением:
            MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
        }
    }
}