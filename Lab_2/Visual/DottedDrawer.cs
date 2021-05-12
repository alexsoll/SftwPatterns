using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace swtf_lab2.Visual
{
    class DottedDrawer : AFormDrawer
    {
        public DottedDrawer(Brush b_, Graphics gr_, Pen p_) : base()
        {
            this.gr = gr_;
            this.br = b_;
            this.pn = p_;
        }

        public override void DrawFinishPoint(IPoint p)
        {
            gr.FillRectangle(br, (float)p.getX(), (float)p.getY(), 5, 5);
        }

        public override void DrawStartPoint(IPoint p)
        {
            this.DrawFinishPoint(p);
        }

        public override void DrawIntermediatePoints(IPoint p1, IPoint p2)
        {
            gr.DrawLine(pn, (float)p1.getX(), (float)p1.getY(), (float)p2.getX(), (float)p2.getY());
        }
    }
}
