using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProcViz
{
    public class RoundedButton : Button
    {
        [Category("Appearance")]
        public int BorderRadius { get; set; } = 25;

        [Category("Appearance")]
        public Color BorderColor { get; set; } = Color.DodgerBlue;

        [Category("Appearance")]
        public float BorderSize { get; set; } = 1.5f;

        [Category("Appearance")]
        public Color HoverBackColor { get; set; } = Color.Empty;

        [Category("Appearance")]
        public Color HoverBorderColor { get; set; } = Color.Empty;

        [Category("Appearance")]
        public Color PressedBackColor { get; set; } = Color.Empty;

        [Category("Appearance")]
        public Color PressedBorderColor { get; set; } = Color.Empty;

        private readonly bool _isDesignMode;
        private Color _defaultBackColor;
        private Color _defaultBorderColor;

        public RoundedButton()
        {
            _isDesignMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;

            Resize += (s, e) => Invalidate();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            _defaultBackColor = BackColor;
            _defaultBorderColor = BorderColor;
        }

        private GraphicsPath GetRoundPath(RectangleF rect, float radius)
        {
            float r = Math.Max(0f, radius) * 2f;
            var path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (HoverBackColor != Color.Empty)
                BackColor = HoverBackColor;
            if (HoverBorderColor != Color.Empty)
                BorderColor = HoverBorderColor;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = _defaultBackColor;
            BorderColor = _defaultBorderColor;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (PressedBackColor != Color.Empty)
                BackColor = PressedBackColor;
            if (PressedBorderColor != Color.Empty)
                BorderColor = PressedBorderColor;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
            {
                if (HoverBackColor != Color.Empty)
                    BackColor = HoverBackColor;
                if (HoverBorderColor != Color.Empty)
                    BorderColor = HoverBorderColor;
            }
            else
            {

                BackColor = _defaultBackColor;
                BorderColor = _defaultBorderColor;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (_isDesignMode)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rectSurface = new RectangleF(0, 0, Width, Height);
            var rectBorder = new RectangleF(1, 1, Width - 2, Height - 2);

            using (var pathSurface = GetRoundPath(rectSurface, BorderRadius))
            using (var pathBorder = GetRoundPath(rectBorder, Math.Max(0, BorderRadius - 1)))
            {
                Color parentColor = this.Parent?.BackColor ?? SystemColors.Control;

                using (var penSurface = new Pen(parentColor, BorderSize))
                using (var penBorder = new Pen(BorderColor, BorderSize))
                {
                    this.Region = new Region(pathSurface);
                    e.Graphics.DrawPath(penSurface, pathSurface);

                    if (BorderRadius > 2)
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
        }
    }
}