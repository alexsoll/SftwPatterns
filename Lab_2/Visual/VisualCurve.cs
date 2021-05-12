using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swtf_lab2.Visual
{
    public class VisualCurve : IDrowable
    {
        private ICurve c;
        private const int n = 20;

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

            d.DrawStartPoint(curveGetPoint(0));

            for (double i = 1; i < n; ++i)
            {
                d.DrawIntermediatePoints(curveGetPoint(i / n), curveGetPoint((i + 1) / n));
            }

            d.DrawFinishPoint(curveGetPoint(1));
        }
    }
}
