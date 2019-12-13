using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace hierarchy
{
    public class Rect : Shape
    {
        public  Rect(double x1, double y1, double x2, double y2, Color c) : base (x1, x2, y1, y2, c)
        {
           
        }
         
        public override double Distance(double x, double y)
        {
            double MinX = Math.Min(X1, X2);
            double MaxX = Math.Max(X1, X2);
            double MinY = Math.Min(Y1, Y2);
            double MaxY = Math.Max(Y1, Y2);

            Line leftside = new Line(MinX, Y2, MinX, Y1, color);
            Line rightside = new Line(MaxX, Y1, MaxX, Y2, color);            
            Line bottomside = new Line(X1, MinY, X2, MinY, color); 
            Line topside = new Line(X1, MaxY, X2, MaxY, color); 

            if (x < MinX)
            {
                return leftside.Distance(x,y);
            }
            else
            {
                if (x > MaxX)
                {
                    return rightside.Distance(x,y);
                }
                else
                    if (y > MaxY)
                    {
                        return topside.Distance(x,y);
                    }
                    else
                        if (y < MinY)
                        {                    
                            return bottomside.Distance(x,y);
                        }
                        else 
                        {
                            return -Math.Min(Math.Min(leftside.Distance(x,y), rightside.Distance(x,y)),Math.Min(bottomside.Distance(x,y), topside.Distance(x,y)));
                        }

            }
        }

        public override void Render(Graphics g)
        {
            //float width = (float)(X2 - X1);
            g.DrawRectangle(new Pen(color), (float)X1, (float)Y1, (float)(X2 - X1), (float)(Y2 - Y1));
        }
    }
}
