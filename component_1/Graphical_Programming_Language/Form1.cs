using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphical_Programming_Language
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void consoledown_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = display.CreateGraphics();
            Pen mypen = new Pen(Color.Black, 5);
            Brush mybrush= new SolidBrush(Color.Black);
            g.DrawLine(mypen, 0, 0, 50, 50);
            Point[] points =
            {
                new Point(50,100),
                new Point(100,150),
                new Point(150,50)

            };
            g.DrawRectangle(mypen, 100, 100, 32, 32);
            g.DrawPolygon(mypen, points);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
