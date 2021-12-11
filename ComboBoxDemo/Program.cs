using System;
using System.Drawing;
using System.Windows.Forms;
namespace ComboBoxDemo
{

    class MyForm : Form
    {
        private string[] animals = { "Волк", "Лиса", "Медведь", "Енот" };
        private string[] files = { "wolf.png", "fox.png", "bear.png", "raccoon.png" };
        private string path = "C:/Users/Oleksandr/Pictures/csharp/";
        private int index = 0;
        private Label pict;
        private ComboBox list;

        public MyForm() : base()
        {
            Text = "В мире живтоных";
            Size = new Size(300, 155);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            pict = new Label();
            pict.SetBounds(5, 5, 154, 104);
            pict.BorderStyle = BorderStyle.FixedSingle;
            pict.Image = Image.FromFile(path + files[index]);
            Controls.Add(pict);
            list = new ComboBox();
            list.Items.AddRange(animals);
            list.DropDownStyle = ComboBoxStyle.DropDownList;
            list.SelectedIndex = index;
            list.Left = pict.Right + 5;
            list.Size = new Size(110, 50);
            list.Font = new Font("Courier New", 12, FontStyle.Bold);
            list.SelectedIndexChanged += OnItemChanged;
            Controls.Add(list);
            Button btn = new Button();
            btn.Text = "OK";
            btn.Left = list.Left;
            btn.Top = list.Bottom + 10;
            btn.Width = list.Width;
            btn.Height = 30;
            btn.Font = list.Font;
            btn.Click += OnButtonClick;
            Controls.Add(btn);
        }
        private void OnItemChanged(object obj, EventArgs ea)
        {
            int index = list.SelectedIndex;
            pict.Image = Image.FromFile(path + files[index]);
        }
        private void OnButtonClick(object obj, EventArgs ea)
        {
            Application.Exit();
        }
        internal class Program
        {
            public static void Main(string[] args)
            {
                Application.Run(new MyForm());
            }
        }

    }
}