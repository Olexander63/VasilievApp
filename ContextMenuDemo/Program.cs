using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContextMenuDemo
{
    class MyForm : Form
    {
        private TextBox tb;
        private Label lbl;

        private bool checkIt(string name)
        {
            switch (name)
            {
                case "Волк":
                case "Лиса":
                case "Медведь":
                case "Енот":
                    return true;
                default:
                    return false;
            }
        }

        private string getFile(string name)
        {
            string path = "C:/Users/Oleksandr/Pictures/csharp/";
            string res = "";
            switch (name)
            {
                case "Волк":
                    res = "wolf.png";
                    break;
                case "Лиса":
                    res = "fox.png";
                    break;
                case "Медведь":
                    res = "bear.png";
                    break;
                case "Енот":
                    res = "raccoon.png";
                    break;
            }

            return path + res;
        }

        public MyForm()
        {
            int H = 104;
            int W = 154;
            Width = W + 25;
            Height = 240;
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterScreen;
            tb = new TextBox();
            tb.Location = new Point(5, 5);
            tb.Width = W;
            tb.Font = new Font("Courier New", 12, FontStyle.Bold);
            tb.KeyUp += (x, y) =>
            {
                if (checkIt(tb.Text))
                {
                    Text = tb.Text;
                    lbl.Image = Image.FromFile(getFile(tb.Text));
                }
            };
            Controls.Add(tb);
            lbl = new Label();
            lbl.Top = tb.Bottom + 5;
            lbl.Left = 5;
            lbl.Size = new Size(W, H);
            lbl.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbl);
            CheckBox option = new CheckBox();
            option.Width = W;
            option.Height = 20;
            option.Left = 5;
            option.Top = lbl.Bottom + 5;
            option.Text = "Заблокировать поле";
            option.CheckedChanged += (x, y) =>
            {
                tb.Enabled = !option.Checked;
                tb.Text = "";
            };
            Controls.Add(option);
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Волк");
            menu.Items.Add("Лиса");
            menu.Items.Add("Медведь");
            menu.Items.Add("Енот");
            for (int k = 0; k < menu.Items.Count; k++)
            {
                menu.Items[k].Click += (x, y) =>
                {
                    string txt = ((ToolStripMenuItem)x).Text;
                    lbl.Image = Image.FromFile(getFile(txt));
                    this.Text = txt;
                    option.Checked = true;
                };
            }

            lbl.ContextMenuStrip = menu;
            Button btn = new Button();
            btn.Text = "OK";
            btn.SetBounds(5, option.Bottom + 5, W, 30);
            btn.Click += (x, y) => { Application.Exit(); };
            Controls.Add(btn);
            menu.Items[0].PerformClick();
        }
    }

    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new MyForm());
        }
    }
}