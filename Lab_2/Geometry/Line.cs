using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swtf_lab2
{
    class Line : ACurve
    {
        public Line(IPoint a_, IPoint b_) : base(a_, b_) {}

        public override IPoint GetPoint(double t)
        {
            Point p = new Point();

            p.setX((1 - t) * a.getX() + t * b.getX());
            p.setY((1 - t) * a.getY() + t * b.getY());

            return p;
        }
    }
}
