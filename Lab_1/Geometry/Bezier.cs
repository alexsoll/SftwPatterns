using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Bezier : ACurve
    {
        IPoint c;
        IPoint d;

        public Bezier(IPoint a_, IPoint b_, IPoint c_, IPoint d_) : base(a_, b_) 
        {
            c = c_;
            d = d_;
        }

        public override IPoint GetPoint(double t)
        {
            Point p = new Point();

            p.setX(Math.Pow((1 - t), 3) * a.getX() + 3 * t * Math.Pow((1 - t), 2) * c.getX() + 3 * Math.Pow(t , 2) * (1 - t) * d.getX() + Math.Pow(t, 3) * b.getX());
            p.setY(Math.Pow((1 - t), 3) * a.getY() + 3 * t * Math.Pow((1 - t), 2) * c.getY() + 3 * Math.Pow(t, 2) * (1 - t) * d.getY() + Math.Pow(t, 3) * b.getY());

            return p;
        }
    }
}
