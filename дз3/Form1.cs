using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace дз3
{
    public partial class Form1 : Form
    {
        PointF Center;
        double u = Math.PI/6;
        public Form1()
        {
            InitializeComponent();
            Center.X = this.ClientSize.Width / 2;
            Center.Y = this.ClientSize.Height / 2;
        }
        List<Shape> LS = new List<Shape>();

        private void Form1_Load(object sender, EventArgs e)
        {

            LS.Add(new Rect(200, 10, 300, 400, Color.Yellow));
            LS.Add(new Rect(600, 50, 700, 430, Color.Red));
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        { PointF p;
            foreach (Shape s in LS)
            {
                s.Render(e.Graphics);
                if (IsInter(s, Center, u, out p))
                {
                    e.Graphics.DrawLine(new Pen(Color.Red), Center.X, Center.Y, (float)p.X, (float)p.Y);

                }
            }
           // s.Render(e.Graphics);

            double x1, y1;
            x1 = Center.X + 50 * Math.Cos(u);
            y1 = Center.Y - 50 * Math.Sin(u);

            //e.Graphics.DrawLine(new Pen(Color.Red), Center.X, Center.Y, (float)x1, (float)y1);
           
            if (IsInter(LS[0], Center, u, out p))
            {
                e.Graphics.DrawLine(new Pen(Color.Red), Center.X, Center.Y, (float)p.X, (float)p.Y);

            }

        }

        public bool IsInter(Shape s, PointF P0, double u, out PointF P1)
        {
            P1 = P0;
            double d = s.Distance(P1);
            double d0 = d;
            while (Math.Abs(d)>0.001)
            {
                P1.X = (float)(P1.X + d * Math.Cos(u));
                P1.Y = (float)(P1.Y - d * Math.Sin(u));
                d0 = d;
                d = s.Distance(P1);
                if (d0 < d) return false;
            }

            return true;

        }
    }
}
