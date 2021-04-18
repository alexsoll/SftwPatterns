using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Visual
{
    public class VisualCurve : IDrowable
    {
        private ICurve c;

        public VisualCurve(ICurve c_)
        {
            this.c = c_;
        }

        protected IPoint curveGetPoint(double t)
        {
            return c.GetPoint(t);
        }

        public void Draw(IDrawer d)
        {
            IPoint p = new Point();
            IPoint p1 = new Point();

            p = curveGetPoint(0);
            d.DrawFinishPoint(p);

            for (double i = 0; i < 1; i += 0.02)
            {
                p = curveGetPoint(i);
                p1 = curveGetPoint(i + 0.01);
                d.DrawIntermediatePoints(p, p1);
            }

            p = curveGetPoint(1);
            d.DrawFinishPoint(p);
        }
    }
}
