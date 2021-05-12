using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace swtf_lab2.Visual
{
    abstract class AFormDrawer : IDrawer
    {
        protected Brush br;
        protected Graphics gr;
        protected Pen pn;

        public abstract void DrawFinishPoint(IPoint p);

        public abstract void DrawIntermediatePoints(IPoint s, IPoint f);

        public abstract void DrawStartPoint(IPoint p);
    }
}
