using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Graphical_Programming_Language
{
    public class Triangle : Shapes
    {
        private  Point[] point;

        public Triangle(Point[] point)
        {
            this.point = point;
        }
        public void Draw(Graphics surface)
        {
            Pen pen = new Pen(Color.Black, 2);
            surface.DrawPolygon(pen, point);
        }
    }
}
