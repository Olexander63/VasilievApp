using System;
using System.Drawing;
using System.Windows.Forms;

namespace MoreSimpleForm
{
    class MyForm:Form
    {
        private Color baseColor;

        public MyForm(string txt) : base()
        {
            Text = txt;
            Height = 200;
            Width = 300;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            baseColor = BackColor;
            MouseEnter += (a, b) =>
            {
                BackColor = Color.Red;
            };
            MouseLeave += (a, b) =>
              {
                  BackColor = baseColor;
              };        
        }

        public static void show(string txt)
        {
            Application.Run(new MyForm(txt));
        }

    }
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            MyForm.show("Первое окно");
            MyForm.show("Второе окно");
        }
    }
}