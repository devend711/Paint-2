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
        // point1 is top-left of bounding rectangle
        protected Point point1, point2;
        protected Pen pen;
        protected Brush brush;
        protected Rectangle rect;
        protected Boolean isFilled, isOutlined;
        public virtual void Draw(Graphics g) { }
    }

    class paintLine : Paintable
    {
        public paintLine(Point p1, Point p2, Pen pen)
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

    class paintRectangle : Paintable
    {
        public paintRectangle(Point p1, int width, int height, Pen pen, Brush brush, bool isFilled, bool isOutlined)
        {
            this.pen = pen;
            this.brush = brush;
            this.isFilled = isFilled;
            this.isOutlined = isOutlined;
            this.rect = new Rectangle(p1, new Size(width, height));
        }

        public override void Draw(Graphics g) // figure out how to draw based on isFilled and isOutlined
        {
            if (isOutlined && !isFilled)
            {
                g.DrawRectangle(pen, rect);
            }
            else if (isFilled && !isOutlined)
            {
                g.FillRectangle(brush, rect);
            }
            else if (isFilled && isOutlined)
            {
                g.FillRectangle(brush, rect);
                g.DrawRectangle(pen, rect);
            }
        }
    }

    class paintEllipse : Paintable
    {
        public paintEllipse(Point p1, int width, int height, Pen pen, Brush brush, bool isFilled, bool isOutlined)
        {
            this.pen = pen;
            this.brush = brush;
            this.isFilled = isFilled;
            this.isOutlined = isOutlined;
            this.rect = new Rectangle(p1, new Size(width, height));
        }
        public override void Draw(Graphics g)
        {
            if (isOutlined && !isFilled)
            {
                g.DrawEllipse(pen, rect);
            }
            else if (isFilled && !isOutlined)
            {
                g.FillEllipse(brush, rect);
            }
            else if (isFilled && isOutlined)
            {
                g.FillEllipse(brush, rect);
                g.DrawEllipse(pen, rect);
            }
        }
    }

    class paintText : Paintable
    {
        string text;
        Font font;

        public paintText(Point p1, int width, int height, Brush brush, string text, Font font)
        {
            this.brush = brush;
            this.font = font;
            this.text = text;
            this.rect = new Rectangle(p1, new Size(width, height));
        }

        public override void Draw(Graphics g)
        {
            g.DrawString(text, font, brush, rect);
        }
    }
}
