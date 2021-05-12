using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swtf_lab2
{
    public interface ICurve
    {
        IPoint GetPoint(double t);
    }
}
