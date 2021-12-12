using System;
using System.Drawing;
using System.Windows.Forms;

namespace List
{
    class MyForm : Form
    {
        public MyForm(string[,] data, string title, string path) : base()
        {
            Text = title;
            Size = new Size(295, 155);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Font = new Font("Times New Roman", 11, FontStyle.Italic | FontStyle.Bold);
            Label pict = new Label();
            pict.SetBounds(5, 5, 154, 104);
            pict.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pict);
            ListBox list = new ListBox();
            list.Left = pict.Right + 5;
            list.Top = pict.Top;
            for (int k = 0; k < data.GetLength(1); k++)
            {
                list.Items.Add(data[0, k]);
            }

            list.SelectedIndexChanged += (x, y) =>
            {
                int index = list.SelectedIndex;
                pict.Image = Image.FromFile(path + data[1, index]);
            };
            Controls.Add(list);
            Button btn = new Button();
            btn.Text = "OK";
            btn.Width = list.Width;
            btn.Height = 25;
            btn.Left = list.Left;
            btn.Top = pict.Bottom - btn.Height;
            btn.Click += (x, y) =>
            {
                Application.Exit();
            };
            list.SetSelected(list.Items.Count - 1, true);
        }
    }
    class Program
    {
        [STAThread]

        public static void Main(string[] args)
        {
            string[,] data = {{"Волк","Лиса","Медведь","Енот"},
                { "wolf.png","fox.png","bear.png","raccoon.png"} };
            string title = "В мире животных";
            string path = "C:/Users/Oleksandr/Pictures/csharp/";
            MyForm wnd = new MyForm(data, title, path);
            Application.Run(wnd);
        }
    }
}