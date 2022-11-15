using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOM
{
    class CustomGraphic
    {
        readonly Graphics g;
        readonly Panel p;

        public CustomGraphic(Panel p)
        {
            this.p = p;
            g = p.CreateGraphics();
        }

        public CustomGraphic()
        {
        }

        public void FillRectangle(Brush brush, float x, float y, float width, float height)
        {
            RectangleF bounds = new();
            bounds.X = (float)((x + 300) / 600.0) * p.Width;
            bounds.Y = (float)((y + 300) / 600.0) * p.Height;
            bounds.Width = width;
            bounds.Height = height;
            g.FillRectangle(brush, bounds);
        }

        public void DrawLine(Pen pen, PointF p1, PointF p2)
        {
            p1.X = (float)((p1.X + 300) / 600.0) * p.Width;
            p1.Y = (float)((p1.Y + 300) / 600.0) * p.Height;
            p2.X = (float)((p2.X + 300) / 600.0) * p.Width;
            p2.Y = (float)((p2.Y + 300) / 600.0) * p.Height;
            g.DrawLine(pen, p1, p2);
        }

        public void Clear()
        {
            g.Clear(Color.White);
        }
    }
}
