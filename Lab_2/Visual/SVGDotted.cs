using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swtf_lab2.Visual
{
    class SVGDotted : ASVGDrawer
    {
        public override void DrawFinishPoint(IPoint p)
        {
            content.Append("<rect x=\"" + p.getX() + "\" y=\"" + p.getY() + "\" width=\"10\" height=\"10\" stroke=\"black\" fill=\"black\" /> \n");
        }

        public override void DrawIntermediatePoints(IPoint s, IPoint f)
        {
            content.Append("<line x1=\"" + s.getX() + "\" y1=\"" + s.getY() + "\" x2=\"" + f.getX() + "\" y2=\"" + f.getY() + "\" stroke=\"black\" /> \n");
        }

        public override void DrawStartPoint(IPoint p)
        {
            content.Append("<rect x=\"" + p.getX() + "\" y=\"" + p.getY() + "\" width=\"10\" height=\"10\" stroke=\"black\" fill=\"black\" /> \n");
        }
    }
}
