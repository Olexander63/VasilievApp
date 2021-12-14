using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursorDemo
{
    class MyForm : Form
    {
        Pen p;
        Graphics g;

        public MyForm()
        {
            Width = 325;
            Height = 380;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Text = "Координаты кусора";
            Label lbl = new Label();
            lbl.Width = 300;
            lbl.Height = 30;
            lbl.Location = new Point(5, 5);
            lbl.BorderStyle = BorderStyle.Fixed3D;
            lbl.Font = new Font("Arial", 10, FontStyle.Bold);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(lbl);
            Panel pnl = new Panel();
            pnl.Width = lbl.Width;
            pnl.Height = 300;
            pnl.Top = lbl.Bottom + 5;
            pnl.Left = lbl.Left;
            pnl.BorderStyle = BorderStyle.Fixed3D;
            pnl.BackColor = Color.Yellow;
            pnl.Cursor = Cursors.Hand;
            p = new Pen(Color.Blue, 3);
            g = pnl.CreateGraphics();
            pnl.MouseMove += (obj, ea) =>
            {
                pnl.Refresh();
                lbl.Text = "Горизонталь: " + ea.X;
                lbl.Text += "    ";
                lbl.Text += "Вертикаль :" + ea.Y;
                g.DrawLine(p,new Point(0,ea.Y),new Point(pnl.ClientSize.Width,ea.Y) );
                g.DrawLine(p,new Point(ea.X,0),new Point(ea.X,pnl.ClientSize.Height) );
            };
            pnl.MouseLeave += (obj, ea) =>
            {
                lbl.Text = "";
                pnl.Refresh();
            };
            Controls.Add(pnl);
        }

        ~MyForm()
        {
            g.Dispose();
            p.Dispose();
        }
    }

    internal class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.Run(new MyForm());
        }
    }
}