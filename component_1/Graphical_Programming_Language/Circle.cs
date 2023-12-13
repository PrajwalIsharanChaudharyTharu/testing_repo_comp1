using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Graphical_Programming_Language
{
    /// <summary>
    /// Represents a Circle shape in a Graphical Programming Language.
    /// </summary>
    public class Circle : Shapes
    {
        private int xCoordinate, yCoordinate, diameter;

        /// <summary>
        /// Initializes a new instance of the Circle class with specified coordinates and diameter.
        /// </summary>
        /// <param name="xCoordinate">The x-coordinate of the Circle's center.</param>
        /// <param name="yCoordinate">The y-coordinate of the Circle's center.</param>
        /// <param name="diameter">The diameter of the Circle.</param>

        public Circle(int xCoordinate, int yCoordinate , int diameter) 
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate; 
            this.diameter = diameter;
        }

        /// <summary>
        /// Draws the Circle on a graphics surface.
        /// </summary>
        /// <param name="surface">The graphics surface to draw the Circle on.</param>

        public void Draw(Graphics surface)
        {
            // Draws the Circle using the provided coordinates and diameter with a black pen.
            surface.DrawEllipse(Pens.Black, xCoordinate, yCoordinate, diameter, diameter);
        }
    }
}
