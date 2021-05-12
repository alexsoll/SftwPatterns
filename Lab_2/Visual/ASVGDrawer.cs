using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swtf_lab2.Visual
{
    abstract class ASVGDrawer : IDrawer
    {
        protected StringBuilder content = new StringBuilder();

        public ASVGDrawer()
        {
            content.Append("<svg viewBox=\"0 0 500 500\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\">\n");
        }

        public StringBuilder GetContent()
        {
            return this.content;
        }

        public abstract void DrawFinishPoint(IPoint p);

        public abstract void DrawIntermediatePoints(IPoint s, IPoint f);

        public abstract void DrawStartPoint(IPoint p);
        
    }
}
