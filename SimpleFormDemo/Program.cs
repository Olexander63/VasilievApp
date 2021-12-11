using System;
using System.Windows.Forms;

namespace SimpleFormDemo
{
    public class SimpleFormDemo
    {
        [STAThread]
        public static void Main()
        {
            Form mf = new Form();
            mf.Text = "Простое окно";
            mf.Height = 200;
            mf.Width = 300;
            Application.Run(mf);
        }
    }
}