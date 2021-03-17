using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Point : IPoint
    {
        double x;
        double y;

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public void setX(double x_)
        {
            this.x = x_;
        }

        public void setY(double y_)
        {
            this.y = y_;
        }
    }
}
