using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace дз3
{
    public abstract class Shape
    {
        public Color Col
        {
            get; set;
        }
            public PointF P1
            {
                get; set;
            }
            public PointF P2
            {
                get; set;
            }
            public Shape(double x1, double y1, double x2, double y2, Color c)
            {
                P1 = new PointF((float)x1, (float)y1);
                P2 = new PointF((float)x2, (float)y2);
            Col = c;
            }
            public Shape(PointF P1, PointF P2, Color c)
            {
                this.P1 = P1;
                this.P2 = P2;
            Col = c;
        }
            public abstract double Distance(PointF T);
        public abstract void Render(Graphics g);

            public double Distance(double x, double y)
            {
                return Distance(new PointF((float)x, (float)y));
            }
    }
}

