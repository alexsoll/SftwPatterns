using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swtf_lab2
{
    abstract class ACurve : ICurve
    {
        protected IPoint a;
        protected IPoint b;

        public ACurve(IPoint a_, IPoint b_)
        {
            this.a = a_;
            this.b = b_;
        }

        public abstract IPoint GetPoint(double t);
    }
}
