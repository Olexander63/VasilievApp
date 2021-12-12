using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextBoxAndCheckBoxDemo
{
    class MyInputBox : Form
    {
        private class MyForm : Form
        {
            private string[] animals = { "Волк", "лиса", "Медведь", "Енот" };
            private string[] files = { "wolf.png", "fox.png", "bear.png", "raccoon.png" };
            private string path = "C:/Users/Oleksandr/Pictures/csharp/";

            public MyForm(string t, bool state) : base()
            {
                string txt = "Жираф", file = "giraffe.png";
                for (int k = 0; k < animals.Length; k++)
                {
                    if ((t == animals[k]) || ((t.ToLower() == animals[k].ToLower()) & state))
                    {
                        txt = animals[k];
                        file = files[k];
                        break; ;
                    }

                }

                Text = txt;
                Font = new Font("Courier New", 12, FontStyle.Bold);
                FormBorderStyle = FormBorderStyle.Fixed3D;
                MaximizeBox = false;
                Image img = Image.FromFile(path + file);
                int h = img.Height;
                int w = img.Width;
                Label lbl = new Label();
                lbl.Image = img;
                lbl.SetBounds(10, 10, w + 4, h + 4);
                lbl.BorderStyle = BorderStyle.FixedSingle;
                Button btn = new Button();
                btn.Text = "OK";
                btn.SetBounds(w / 4 + 10, lbl.Bottom + 5, w / 2, 30);
                btn.Click += (x, y) =>
                {
                    Application.Exit();
                };
                Size = new Size(w + 40, btn.Bottom + 50);
                StartPosition = FormStartPosition.CenterScreen;
                Controls.Add(lbl);
                Controls.Add(btn);
            }
        }

        private CheckBox option;
        private Button ok;
        private Button cancel;
        private TextBox tb;

        public MyInputBox() : base()
        {
            Size = new Size(250, 190);
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Название животного";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Font = new Font("Times New Roman", 13, FontStyle.Regular);
            Label lbl = new Label();
            lbl.Text = "Какое животное показать?";
            lbl.Height = 30;
            lbl.Width = Width - 30;
            lbl.Left = 10;
            lbl.Top = 10;
            Controls.Add(lbl);
            tb = new TextBox();
            tb.Width = Width - 30;
            tb.Left = lbl.Left;
            tb.Top = lbl.Bottom + 5;
            Controls.Add(tb);
            option = new CheckBox();
            option.Text = "Не учитывать регистр";
            option.Left = tb.Left;
            option.Top = tb.Bottom + 5;
            option.Height = 30;
            option.Width = tb.Width;
            option.Checked = true;
            Controls.Add(option);
            ok = new Button();
            ok.Text = "OK";
            ok.Width = Width / 2 - 20;
            ok.Height = 30;
            ok.Left = tb.Left;
            ok.Top = option.Bottom + 5;
            ok.Click += OnBtnsClick;
            cancel = new Button();
            cancel.Text = "Отмена";
            cancel.Size = ok.Size;
            cancel.Top = ok.Top;
            cancel.Left = tb.Right - cancel.Width;
            cancel.Click += OnBtnsClick;
            Controls.Add(ok);
            Controls.Add(cancel);
        }

        public static void ShowInputBox()
        {
            Application.Run(new MyInputBox());
        }

        private void OnBtnsClick(object obj, EventArgs ea)
        {
            Button btn = (Button)obj;
            if (btn == ok)
            {
                Visible = false;
                new MyForm(tb.Text, option.Checked).ShowDialog();

            }
            else
            {
                Application.Exit();
            }

        }
    }
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            MyInputBox.ShowInputBox();
        }
    }
}