using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Visual
{
    class Intermittent : IDrawer
    {
        private IDrawer d;
        private int count;

        public Intermittent(IDrawer d_)
        {
            this.d = d_;
            this.count = 0;
        }

        public void DrawFinishPoint(IPoint p)
        {
            d.DrawFinishPoint(p);
        }

        public void DrawIntermediatePoints(IPoint p1, IPoint p2)
        { 
            if (count % 2 != 0)
            {
                d.DrawIntermediatePoints(p1, p2);
            }
            this.count++;
        }
    }
}
