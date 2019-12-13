using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace hierarchy
{
    public class Line : Shape
    {
        public Line(double x1, double y1, double x2, double y2, Color c) : base(x1, x2, y1, y2, c)
        {
        }

       
        public override double Distance(double x, double y)
        {
            double Nx, Ny;
            Nx = X2 - X1;
            Ny = Y2 - Y1; //
            double l = D(X1, Y1, X2,  Y2);
            Nx /= l;
            Ny /= l;
            double dPx, dPy;
            dPx = x - X1;
            dPy = y - Y1; // problem was here.
            double m = Nx * dPx + Ny * dPy;
            if (m < 0)
            {
                return D(x, y, X1, Y1);
            }
            else if (m > l)
            {
                return D(x, y, X2, Y2);
            }
            else
            {
                return D(x, y, X1 + m * Nx, Y1 + m * Ny);
            }

        }

        public override void Render(Graphics g)
        {
            g.DrawLine(new Pen(color), (float)X1, (float)Y1, (float)(X2 - X1), (float)(Y2 - Y1));
        }
    }
}
