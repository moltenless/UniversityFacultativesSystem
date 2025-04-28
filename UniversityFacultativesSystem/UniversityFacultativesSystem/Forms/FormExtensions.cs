using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UniversityFacultativesSystem
{
    public static class FormExtensions
    {
        private static List<(Control, float, Color)> controlsRounding = new List<(Control, float, Color)>();

        public static void Style(this Control control, float rounding, Color border)
        {
            controlsRounding.Add((control, rounding, border));
            control.Paint += PaintElliptically;

        }

        private static void PaintElliptically(object sender, PaintEventArgs e)
        {
            int rdus = 20;

            var options = controlsRounding.Find(r => r.Item1 == sender);
            OnPaint(sender as Control, e, options.Item2, options.Item3);

            void OnPaint(Control control, PaintEventArgs _e, float rounding, Color border)
            {
                RectangleF Rect = new RectangleF(0, 0, control.Width, control.Height);
                using (GraphicsPath GraphPath = GetRoundPath(Rect, rdus))
                {
                    control.Region = new Region(GraphPath);
                    
                    using (Pen pen = new Pen(border, rounding))
                    {
                        pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                        _e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        _e.Graphics.DrawPath(pen, GraphPath);
                    }
                }
            }

            GraphicsPath GetRoundPath(RectangleF Rect, int radius)
            {
                float r2 = radius / 2f;
                GraphicsPath GraphPath = new GraphicsPath();
                GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
                GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
                GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
                GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
                GraphPath.AddArc(Rect.X + Rect.Width - radius,
                        Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
                GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
                GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
                GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
                GraphPath.CloseFigure();
                return GraphPath;
            }
        }
    }
}