using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swtf_lab2
{
    public partial class Form1 : Form
    {
        Graphics gr;
        Brush br;
        Pen pn;
        List<ICurve> lines = new List<ICurve>();

        public Form1()
        {
            InitializeComponent();
            //gr = this.CreateGraphics();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            gr = panel1.CreateGraphics();
            br = (Brush)Brushes.Black;
            pn = new Pen(Color.Black);

            pn.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            IPoint a = new Point();
            IPoint b = new Point();
            a.setX(100);
            a.setY(100);
            b.setX(200);
            b.setY(200);

            ICurve line = new Line(a, b);
            lines.Add(line);

            Visual.VisualCurve curve = new Visual.VisualCurve(line);
            Visual.AFormDrawer dottetDrawer = new Visual.DottedDrawer(br, gr, pn);

            curve.Draw(dottetDrawer);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gr = panel2.CreateGraphics();
            br = (Brush)Brushes.Green;
            pn = new Pen(Color.Green);

            //pn.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            IPoint a = new Point();
            IPoint b = new Point();
            a.setX(100);
            a.setY(100);
            b.setX(200);
            b.setY(200);

            ICurve line = new Line(a, b);
            lines.Add(line);

            Visual.VisualCurve curve = new Visual.VisualCurve(line);
            Visual.AFormDrawer contDrawer = new Visual.ContinuousDrawer(br, gr, pn);

            curve.Draw(contDrawer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visual.ASVGDrawer svgCont = new Visual.SVGContinuous();
            Visual.SVGSaver svgSaver = new Visual.SVGSaver(lines);
            svgSaver.save(svgCont, "//ContLines.svg");
        }
    }
}
