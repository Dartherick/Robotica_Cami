using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShooterBot
{
    internal class CircularButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0,0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);
        }
    }
    internal class TriangleButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float h = this.Height;
            float w = this.Width;

            PointF[] pts = new PointF[] { new PointF(w / 2, 0), new PointF(0, w), new PointF(w, h) };
            g.FillPolygon(new SolidBrush(this.BackColor), pts);
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(pts);

            this.Region = new Region(gp);

            base.OnPaint(pevent);
        }
    }
}
