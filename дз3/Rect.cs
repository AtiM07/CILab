using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз3
{
    public class Rect : Shape
    { 
        public Rect(PointF P1, PointF P2, Color c) : base(P1, P2, c)
        {
        }

        public Rect(double x1, double y1, double x2, double y2, Color c) : base(x1, y1, x2, y2, c)
        {
        }

        public override double Distance(PointF T)
        {
            if (P1.X >= T.X) //слева от х
                {
                if (T.Y <= P1.Y) //сверху 
                {
                    return Math.Sqrt(Math.Pow((T.X - P1.X), 2) + Math.Pow((T.Y - P1.Y), 2));
                }
                else
            if (T.Y >= P2.Y) //снизу
                {
                    return Math.Sqrt(Math.Pow((T.X - P1.X), 2) + Math.Pow((T.Y - P2.Y), 2));
                }
                else
                {
                    return P1.X - T.X;
                }
            }
            else 
            if (P2.X <= T.X) // справа от х
            {
                if (T.Y <= P1.Y) //сверху 
                {
                    return Math.Sqrt(Math.Pow((T.X - P2.X), 2) + Math.Pow((T.Y - P1.Y), 2));
                }
                else
            if (T.Y >= P2.Y) //снизу
                {
                    return Math.Sqrt(Math.Pow((T.X - P2.X), 2) + Math.Pow((T.Y - P2.Y), 2));
                }
                else
                {
                    return T.X - P2.X;
                }

            }
            else {

                if (T.Y <= P1.Y) return P1.Y - T.Y; // сверху
                else
                if (T.Y >= P2.Y) return T.Y - P2.Y;//снизу
                else {
                    return Math.Min(
                        Math.Min(T.X - P1.X, T.Y - P1.Y),
                        Math.Min(P2.X - T.X, P2.Y - T.Y)
                        );
                }
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawRectangle(new Pen(Col), P1.X, P1.Y, P2.X-P1.X, P2.Y-P1.Y);
        }
    }
}
