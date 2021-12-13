using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainMenuDemo
{
    class MyForm : Form
    {
        private string path = "C:/Users/Oleksandr/Pictures/csharp/";
        private Label pict;
        private Button btn;

        public MyForm() : base()
        {
            Size = new Size(240, 230);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "В мире животных";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MainMenu menu = new MainMenu();
            MenuItem prog = new MenuItem();
            prog.MenuItems.Add("Выход", OnButtonClick);
            MenuItem beautiful = new MenuItem("Красивые");
            MenuItem fox = new MenuItem("Лиса");
            fox.Click += (x, y) => { set("Лиса", "fox.png"); };
            MenuItem raccon = new MenuItem("Енот");
            raccon.Click += (x, y) => { set("Енот", "raccoon.png"); };
            beautiful.MenuItems.Add(fox);
            beautiful.MenuItems.Add(raccon);
            MenuItem strong = new MenuItem("Сильные");
            MenuItem bear = new MenuItem("Медведь");
            bear.Click += (x, y) => { set("Медведь", "bear.png"); };
            MenuItem wolf = new MenuItem("Волк");
            strong.MenuItems.Add(wolf);
            strong.MenuItems.Add(bear);
            menu.MenuItems.Add(prog);
            menu.MenuItems.Add(beautiful);
            menu.MenuItems.Add(strong);
            Menu = menu;
            ToolStrip ts = new ToolStrip();
            ToolStripButton tsbA = new ToolStripButton(Image.FromFile(path + "fox.png"));
            ToolStripButton tsbB = new ToolStripButton(Image.FromFile(path + "raccoon.png"));
            ToolStripButton tsbC = new ToolStripButton(Image.FromFile(path + "wolf.png"));
            ToolStripButton tsbD = new ToolStripButton(Image.FromFile(path + "bear.png"));
            tsbA.ToolTipText = "Лиса";
            tsbB.ToolTipText = "Енот";
            tsbC.ToolTipText = "Волк";
            tsbD.ToolTipText = "Ведведь";
            tsbA.Click += (x, y) => fox.PerformClick();
            tsbB.Click += (x, y) => raccon.PerformClick();
            tsbC.Click += (x, y) => wolf.PerformClick();
            tsbD.Click += (x, y) => bear.PerformClick();
            ts.Items.Add(tsbA);
            ts.Items.Add(tsbB);
            ts.Items.Add(tsbC);
            ts.Items.Add(tsbD);
            Controls.Add(ts);
            pict = new Label();
            pict.SetBounds(35, 25, 154, 104);
            pict.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pict);
            btn = new Button();
            btn.Left = pict.Left + 20;
            btn.Top = pict.Bottom + 10;
            btn.Width = pict.Width - 40;
            btn.Height = 30;
            btn.Font = new Font("Courier New", 12, FontStyle.Bold);
            btn.Click += OnButtonClick;
            Controls.Add(btn);
            wolf.PerformClick();
        }

        private void set(string name, string file)
        {
            btn.Text = name;
            pict.Image = Image.FromFile(path + file);
        }

        private static void OnButtonClick(object obj, EventArgs ea)
        {
            Application.Exit();
        }
    }

    public  class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.Run(new MyForm());
        }
    }
}