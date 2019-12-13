using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace hierarchy
{
    abstract public class Shape
    {  
        
        public  Shape (double x1, double x2, double y1, double y2, Color c)
        {
            this.X1 = x1;
            this.X2 = x2;
            this.Y1 = y1;
            this.Y2 = y2;
            this.color = c;
            
        }
        public double X1
        {
            get; set;
        }
        public double X2
        {
            get; set;
        }
        public double Y1
        {
            get; set;
        }
        public double Y2
        {
            get; set;
        }
        public Color color
        {
            get; set;
        }
        public abstract double Distance(double x, double y);

        protected static double D(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public abstract void Render(Graphics g);


    }
}
