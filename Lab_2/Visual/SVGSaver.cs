using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swtf_lab2.Visual
{

    class SVGSaver
    {
        private List<ICurve> lines;
        private const int n = 25;

        public SVGSaver(List<ICurve> lines_)
        {
            this.lines = lines_;
        }

        public void save(ASVGDrawer svgDrawer, string file)
        {
            //IPoint p = new Point();
            foreach (var line in lines)
            {
                svgDrawer.DrawStartPoint(line.GetPoint(0));

                for (double i = 1; i < n; i++)
                {
                    svgDrawer.DrawIntermediatePoints(line.GetPoint(i / n), line.GetPoint((i + 1) / n));
                }
                svgDrawer.DrawFinishPoint(line.GetPoint(1));
            }

            svgDrawer.GetContent().Append("</svg>");
            string path = Directory.GetCurrentDirectory();
            string filePath = path + file;

            File.WriteAllText(filePath, svgDrawer.GetContent().ToString());
        }
    }
}
