using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swtf_lab2.Visual
{
    public interface IDrawer
    {
        void DrawStartPoint(IPoint p);

        void DrawIntermediatePoints(IPoint p1, IPoint p2);

        void DrawFinishPoint(IPoint p);
    }
}
