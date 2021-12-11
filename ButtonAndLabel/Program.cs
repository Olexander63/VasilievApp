using System;
using System.Drawing;
using System.Windows.Forms;

namespace ButtonAndLabel
{

    class MyFrom : Form
    {
        public MyFrom(string msg, string title) : base()
        {
            this.Text = title;
            this.Size = new Size(300, 140);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            string file = "C:/Users/Oleksandr/Pictures/wolf.ico";
            this.Icon = new Icon(file);
            Label lbl = new Label();
            lbl.Text = msg;
            lbl.Location = new Point(10, 10);
            lbl.Width = 165;
            lbl.Height = 30;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.BorderStyle = BorderStyle.Fixed3D;
            Font F = new Font("Arial", 12, FontStyle.Italic);
            lbl.Font = F; 
            lbl.ForeColor = Color.Blue;
            this.Controls.Add(lbl);
            Button btn = new Button();
            btn.Text = "Закрыть";
            btn.Bounds = new Rectangle(100, 60, 90, 30);
            btn.Font = new Font(btn.Font.Name,btn.Font.Size+3,FontStyle.Underline|FontStyle.Bold);
            btn.Click += delegate (object a, EventArgs b)
              {
                  Application.Exit();
              };
            this.Controls.Add(btn);
        }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyFrom mf = new MyFrom("Всем привет!", "Окно с кнопкой");
            Application.Run(mf);
        }
    }
}
