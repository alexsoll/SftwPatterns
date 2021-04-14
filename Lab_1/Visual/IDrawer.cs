using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Visual
{
    public interface IDrawer
    {
        void DrawFinishPoint(IPoint p);

        void DrawIntermediatePoints(IPoint p1, IPoint p2);
    }
}
