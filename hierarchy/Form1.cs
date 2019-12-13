using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hierarchy
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes = new List<Shape>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shapes.Add(new Line(100, 30, 500, 100, Color.Red));
            shapes.Add(new Rect(70, 120, 200, 300, Color.Blue));
            shapes.Add(new Rect(50, 50, 350, 400, Color.Green));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Shape s in shapes)
            {
                s.Render(e.Graphics);
            }
        }
    }
}
