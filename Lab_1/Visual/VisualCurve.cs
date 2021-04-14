using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Visual
{
    public abstract class VisualCurve : IDrowable
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

        public abstract void Draw(IDrawer d);
    }
}
