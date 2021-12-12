using System;
using System.Drawing;
using System.Windows.Forms;

namespace RadioButtonDemo
{
    class MyButton : Button
    {
        public MyButton(string name) : base()
        {
            Text = name;
            Click += (x, y) => { Application.Exit(); };
        }
    }

    class MyForm : Form
    {
        private string[] animals = {"Волк", "Лиса", "Медведь", "Енот"};
        private string[] files = {"wolf.png", "fox.png", "bear.png", "raccoon.png"};
        private string path = "C:/Users/Oleksandr/Pictures/csharp/";
        private int index = 0;
        private Label pict;
        private RadioButton[] radio;

        public MyForm() : base()
        {
            Width = 310;
            Height = 200;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(400, 300);
            Text = "В мире животных";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Panel pnl = new Panel();
            pnl.Width = this.ClientSize.Width - 10;
            pnl.Height = ClientSize.Height - 10;
            pnl.Left = 5;
            pnl.Top = 5;
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pict = new Label();
            pict.SetBounds(5, 5, 154, 104);
            pict.BorderStyle = BorderStyle.FixedSingle;
            pict.Image = Image.FromFile(path + files[index]);
            pnl.Controls.Add(pict);
            radio = new RadioButton[animals.Length];
            GroupBox gb = new GroupBox();
            gb.Left = pict.Right + 5;
            gb.Top = pict.Top;
            gb.Width = 115;
            gb.Height = pict.Height;
            gb.Text = "Ваш выбор";
            gb.Font = new Font("Courier New", 12, FontStyle.Bold);
            int h = 17;
            for (int k = 0; k < radio.Length; k++)
            {
                radio[k] = new RadioButton();
                radio[k].Text = animals[k];
                radio[k].Text = animals[k];
                radio[k].Checked = (k == index);
                radio[k].SetBounds(10, 20 + k * (h + 4), 100, h);
                radio[k].CheckedChanged += OnRadioClick;
                gb.Controls.Add(radio[k]);
            }

            pnl.Controls.Add(gb);
            MyButton btn = new MyButton("OK");
            btn.Height = 30;
            btn.Width = pnl.Width / 3;
            btn.Left = pnl.Width / 3;
            btn.Top = pict.Bottom + 5;
            btn.Font = gb.Font;
            pnl.Controls.Add(btn);
            Controls.Add(pnl);
        }

        private void OnRadioClick(object obj, EventArgs ea)
        {
            for (int k = 0; k < radio.Length; k++)
            {
                if (radio[k].Checked)
                {
                    pict.Image = Image.FromFile(path + files[k]);
                    return;
                    ;
                }
            }
        }
    }

    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Run(new MyForm());
        }
    }
}