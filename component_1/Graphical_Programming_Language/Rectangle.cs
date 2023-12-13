using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Graphical_Programming_Language
{
    public class Rectangle : Shapes
    {
        private int xCoordinate, yCoordinate, width, height;

        public Rectangle(int xCoordinate, int yCoordinate, int width, int height)
        {
            this.xCoordinate = xCoordinate; 
            this.yCoordinate = yCoordinate; 
            this.width = width;
            this.height = height;
        }
        public void Draw(Graphics surface)
        {
            Pen mypen = new Pen(Color.Black, 2);
            surface.DrawRectangle(mypen, 0, 0, 40, 60);
        }
    }
}
