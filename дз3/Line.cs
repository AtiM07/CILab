using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace дз3
{
    public class Line: Shape
    {
       // PointF A, B;
        public Line(PointF P1, PointF P2, Color c) : base(P1, P2, c)
        {
           
        }

        public Line(double x1, double y1, double x2, double y2, Color c) : base(x1, y1, x2, y2, c)
        { 
        }
         
        public override double Distance(PointF T)
        {
            double L = Math.Sqrt(Math.Pow((P2.X - P1.X), 2) + Math.Pow((P2.Y - P1.Y), 2));
            double CountC = (((P2.X - P1.X) / L) * (T.X - P1.X)) + (((P2.Y - P1.Y) / L) * (T.Y - P1.Y));
            if (CountC < 0)
            {
                double TN = Math.Sqrt(Math.Pow((T.X - P1.X), 2) + Math.Pow((T.Y - P1.Y), 2));
                return TN;
            }
            else
            if (CountC > L)
            {
                double TK = Math.Sqrt(Math.Pow((T.X - P2.X), 2) + Math.Pow((T.Y - P2.Y), 2));
                return TK;
            }
            else
            {
                double CountP = Math.Pow((T.X - P1.X), 2) + Math.Pow((T.Y - P1.Y), 2);
                double Konez = Math.Sqrt(CountP - Math.Pow(CountC, 2));
                return Konez;
            }

        }

        public override void Render(Graphics g)
        {
            g.DrawRectangle(new Pen(Col), P1.X, P1.Y, P2.X - P1.X, P2.Y - P1.Y);
        }
    }
}
    