using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint2
{
    class Paintable
    {
        // every paintable has a start and end point coordinate
        protected Point point1, point2;
        protected Pen pen;

        public virtual void Draw(Graphics g) { }

    }

    class Line : Paintable
    {
        public Line(Point p1, Point p2, Pen pen)
        {
            this.point1 = p1;
            this.point2 = p2;
            this.pen = pen;
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, point1, point2);
        }
    }

    class Rectangle : Paintable
    {
        public override void Draw(Graphics g)
        {

        }
    }

    class Ellipse : Paintable
    {
        public override void Draw(Graphics g)
        {

        }
    }

    class Text : Paintable
    {
        public override void Draw(Graphics g)
        {

        }
    }
}
