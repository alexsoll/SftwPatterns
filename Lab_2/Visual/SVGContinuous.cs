using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swtf_lab2.Visual
{
    class SVGContinuous : ASVGDrawer
    {
        public override void DrawFinishPoint(IPoint p)
        {
            content.Append("<circle cx=\"" + (int)p.getX() + "\" cy=\"" + (int)p.getY() + "\" r=\"10\" fill=\"green\" /> \n");
        }

        public override void DrawIntermediatePoints(IPoint s, IPoint f)
        {
            content.Append("<line x1=\"" + (int)s.getX() + "\" y1=\"" + (int)s.getY() + "\" x2=\"" + (int)f.getX() + "\" y2=\"" + (int)f.getY() + "\" stroke=\"green\" /> \n");
        }

        public override void DrawStartPoint(IPoint p)
        {
            content.Append("<rect x=\"" + (int)p.getX() + "\" y=\"" + (int)p.getY() + "\" width=\"10\" height=\"10\" stroke=\"green\" fill=\"green\" /> \n");
        }
    }
}
