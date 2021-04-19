using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conference
{
    public partial class Form1 : Form
    {
        public int N;
        public double R;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r_textBox.ReadOnly = true; n_textBox.ReadOnly = true;
            checkBox1.Enabled = false; button1.Enabled = false;
            pixel_num.Refresh(); inCircle_num.Refresh(); pi_label.Refresh();
            N = int.Parse(n_textBox.Text); R = double.Parse(r_textBox.Text);
            int X = ActiveForm.Size.Width; int Y = ActiveForm.Size.Height;
            ActiveForm.Size = new Size(X + X + 20, Y + Y - 40);
            CreateGraph();
        }

        public void CreateGraph()
        {
            Graphics graph = this.CreateGraphics(); 
            Pen pen = new Pen(Color.Black);
            int X = 210, Y = 10, inEllipse = 0;
            Rectangle rect = new Rectangle(X, Y, 200, 200); // прямоугольник
            graph.DrawRectangle(pen, rect);
            RectangleF rectF = new RectangleF(X, Y, 200, 200); // круг
            graph.DrawEllipse(pen, rectF);
            Pen rPen = new Pen(Color.Red), bPen = new Pen(Color.Blue);
            Brush rBrush = Brushes.Red, bBrush = Brushes.Blue;
            Random rnd = new Random(); bool inE = false; double Pi = 0;
            for (int i = 0; i < N; i++)
            {
                int Xp = rnd.Next(0, 200) + X, Yp = rnd.Next(0, 200) + Y;
                if (Math.Pow(Xp - X - 100, 2) + Math.Pow(Yp - Y - 100, 2) <= Math.Pow(R, 2)) { inE = true; }
                else { inE = false; }
                RectangleF pixel = new RectangleF(Xp, Yp, 2, 2);
                Brush tempBrush; Pen tempPen;
                if (inE) { tempBrush = rBrush; tempPen = rPen; inEllipse++; }
                else { tempBrush = bBrush; tempPen = bPen; }
                graph.DrawEllipse(tempPen, pixel); graph.FillEllipse(tempBrush, pixel);
                if (checkBox1.Checked) { Thread.Sleep(300); }
                pixel_num.Text = "Точка №" + (i + 1); pixel_num.Refresh();
                inCircle_num.Text = $"Точек внутри: {inEllipse}"; inCircle_num.Refresh();
                Pi = 4 * (double)inEllipse / N;
                pi_label.Text = $"Pi = {Pi:f3}"; pi_label.Refresh();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
