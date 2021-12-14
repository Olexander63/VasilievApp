using  System.Windows.Forms;

namespace DialogResult1
{
    class DeialogResultDemo
    {
        public static void Main(string[] args)
        {
            string msg, title;
            MessageBoxIcon icn;
            DialogResult res;
            res = MessageBox.Show("Вам нравится С#?", "Риторический вопрос ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                msg = "Добро пожаловать в команду!";
                title = "Наш человек";
                icn = MessageBoxIcon.Information;
            }
            else
            {
                msg = "У Вас нет сердца!";
                title = "Не может быть";
                icn = MessageBoxIcon.Error;
            }

            MessageBox.Show(msg, title, MessageBoxButtons.OK, icn);

        }
    }

}