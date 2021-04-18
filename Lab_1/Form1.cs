using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form, Visual.IDrawer
    {
        Graphics gr;
        Brush br = (Brush)Brushes.Blue;
        Pen pn = new Pen(Color.Black);

        public Form1()
        {
            InitializeComponent();
            gr = this.CreateGraphics();
        }

        public void DrawFinishPoint(IPoint p)
        {
            gr.FillRectangle(br, (float)p.getX(), (float)p.getY(), 2, 2);
        }

        public void DrawIntermediatePoints(IPoint p1, IPoint p2)
        {
            gr.DrawLine(pn, (float)p1.getX(), (float)p1.getY(), (float)p2.getX(), (float)p2.getY());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPoint a = new Point();
            IPoint b = new Point();
            a.setX(100);
            a.setY(100);
            b.setX(200);
            b.setY(200);

            ICurve curve = new Line(a, b);

            Visual.Intermittent decorator = new Visual.Intermittent(this);

            Visual.VisualCurve visualCurve = new Visual.VisualCurve(curve);
            visualCurve.Draw(decorator);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IPoint a = new Point();
            a.setX(300);
            a.setY(100);

            IPoint b = new Point();
            b.setX(250);
            b.setY(250);

            IPoint c = new Point();
            c.setX(100);
            c.setY(150);
            
            IPoint d = new Point();
            d.setX(150);
            d.setY(150);

            ICurve curve = new Bezier(a, b, c, d);

            Visual.VisualCurve visualCurve = new Visual.VisualCurve(curve);
            visualCurve.Draw(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
