using System;
using System.Drawing;
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
            r_textBox.ReadOnly = true; n_textBox.ReadOnly = true; button1.Enabled = false;
            pixel_num.Refresh(); inCircle_num.Refresh(); pi_label.Refresh();
            pi_orig_label.Text = $"Pi (original) = {Math.PI:f7}"; pi_orig_label.Refresh();
            N = int.Parse(n_textBox.Text); R = double.Parse(r_textBox.Text);
            int X = ActiveForm.Size.Width; int Y = ActiveForm.Size.Height;
            ActiveForm.Size = new Size(X + X + 20, Y + Y - 40);
            createGraph();
        }

        public void createGraph()
        {
            Graphics graph = this.CreateGraphics();
            Pen pen = new Pen(Color.Black); // чёрная кисть
            int X = 210, Y = 10, inEllipse = 0, all = 0;
            Rectangle rect = new Rectangle(X, Y, 200, 200); // прямоугольник
            graph.DrawRectangle(pen, rect);
            RectangleF rectF = new RectangleF(X, Y, 200, 200); // круг
            graph.DrawEllipse(pen, rectF);
            Pen rPen = new Pen(Color.Red), bPen = new Pen(Color.Blue); // красная и синяя кисть
            Brush rBrush = Brushes.Red, bBrush = Brushes.Blue; // красная и синяя заливка
            Random rnd = new Random(); 
            bool inE = false; // если точка в круге (inEllipse)
            double Pi = 0;
            for (int i = 0; i < N; i++)
            {
                ActiveForm.Text = "Working";
                int Xp = rnd.Next(0, (int)Math.Round(R + R)), Yp = rnd.Next(0, (int)Math.Round(R + R)); // получение координат точки
                int newXp = adaptiveCoord(Xp) + X, newYp = adaptiveCoord(Yp) + Y; // адаптация координат под маленький график
                if (Math.Pow(Xp - (int)Math.Round(R), 2) + Math.Pow(Yp - (int)Math.Round(R), 2) <= Math.Pow(R, 2)) { inE = true; }
                else { inE = false; } // если (X * X) + (Y * Y) <= (R * R) -> точка внутри окружности
                RectangleF pixel = new RectangleF(newXp, newYp, 2, 2); // создание пикселя
                Brush tempBrush; Pen tempPen; // временные элементы
                if (inE) { tempBrush = rBrush; tempPen = rPen; inEllipse++; }
                else { tempBrush = bBrush; tempPen = bPen; } // выбор цвета (красный - внутри круга, синий - снаружи)
                graph.DrawEllipse(tempPen, pixel); graph.FillEllipse(tempBrush, pixel); // рисовка и заливка точки
                pixel_num.Text = "Точка №" + (i + 1); pixel_num.Refresh(); // порядковый номер точки
                inCircle_num.Text = $"Точек внутри: {inEllipse}"; inCircle_num.Refresh(); // рассчёт и обновление точек внутри
                pi_orig_label.Refresh();
                if (all != 0)
                {
                    Pi = 4 * (double)inEllipse / all;
                    pi_label.Text = $"Pi = {Pi:f7}"; pi_label.Refresh(); // рассчёт и вывод Пи
                }
                all++; // счётчик всех точек
            }
            ActiveForm.Text = "Ready"; // установка названия формы
        }

        public int adaptiveCoord(int N)
        {
            const int smallWidth = 200; // ширина маленького квадрата
            double newN = smallWidth * N / (2 * R); // рассчёт нового значения
            return (int)Math.Round(newN);
        }
    }
}
