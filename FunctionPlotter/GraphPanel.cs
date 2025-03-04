using System;
using System.Drawing;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    public partial class Koordinatensystem : Panel
    {
        private Funktion _funktion;
        private float _skala = 20f; // Maßstab für Zoom
        private Point _offset = new Point(0, 0); // Verschiebung des Koordinatensystems
        private Point _dragStart;
        private bool _dragging = false;
        private Button zoomInButton;
        private Button zoomOutButton;

        public Koordinatensystem()
        {
            DoubleBuffered = true;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;

            this.MouseWheel += Koordinatensystem_MouseWheel;
            this.MouseDown += Koordinatensystem_MouseDown;
            this.MouseMove += Koordinatensystem_MouseMove;
            this.MouseUp += Koordinatensystem_MouseUp;
            this.KeyDown += Koordinatensystem_KeyDown;
            this.Focus();

            // Zoom Buttons
            zoomInButton = new Button { Text = "+", Location = new Point(10, 10), Size = new Size(30, 30) };
            zoomOutButton = new Button { Text = "-", Location = new Point(50, 10), Size = new Size(30, 30) };
            zoomInButton.Click += (s, e) => Zoom(1.1f);
            zoomOutButton.Click += (s, e) => Zoom(0.9f);
            this.Controls.Add(zoomInButton);
            this.Controls.Add(zoomOutButton);
        }

        public void SetFunktion(Funktion funktion)
        {
            _funktion = funktion;
            _skala = 20f;
            _offset = new Point(0, 0); // Reset Position
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_funktion == null) return;

            Graphics g = e.Graphics;
            Pen axisPen = new Pen(Color.Black, 2);
            Pen functionPen = new Pen(Color.Blue, 2);

            int centerX = Width / 2 + _offset.X;
            int centerY = Height / 2 + _offset.Y;

            // Achsen zeichnen
            g.DrawLine(axisPen, centerX, 0, centerX, Height);
            g.DrawLine(axisPen, 0, centerY, Width, centerY);

            // Schrittweite für Beschriftung berechnen
            float step = CalculateDynamicStep();
            DrawAxisLabels(g, centerX, centerY, step);

            // Funktion zeichnen
            float minX = -Width / (2 * _skala) - _offset.X / _skala;
            float maxX = Width / (2 * _skala) - _offset.X / _skala;
            PointF? previousPoint = null;

            for (float x = minX; x <= maxX; x += 0.1f)
            {
                float y = (float)_funktion.Berechne(x);
                if (float.IsInfinity(y) || float.IsNaN(y) || Math.Abs(y) > Height * 10)
                {
                    previousPoint = null;
                    continue;
                }

                float screenX = centerX + x * _skala;
                float screenY = centerY - y * _skala;

                if (previousPoint != null)
                {
                    g.DrawLine(functionPen, previousPoint.Value, new PointF(screenX, screenY));
                }
                previousPoint = new PointF(screenX, screenY);
            }

            axisPen.Dispose();
            functionPen.Dispose();
        }

        private float CalculateDynamicStep()
        {
            float[] steps = { 1, 2, 5, 10, 20, 50, 100 };
            float idealStep = Width / (_skala * 10);
            foreach (float step in steps)
            {
                if (idealStep < step) return step;
            }
            return 100;
        }

        private void DrawAxisLabels(Graphics g, int centerX, int centerY, float step)
        {
            float visibleRangeX = Width / _skala;
            float visibleRangeY = Height / _skala;
            Pen gridPen = new Pen(Color.LightGray, 1);

            for (float x = (float)(Math.Ceiling(-visibleRangeX / 2 / step) * step); x <= visibleRangeX / 2; x += step)
            {
                int screenX = centerX + (int)(x * _skala);
                if (screenX >= 0 && screenX <= Width)
                {
                    g.DrawLine(gridPen, screenX, 0, screenX, Height);
                    g.DrawString(x.ToString(), new Font("Arial", 8), Brushes.Black, screenX - 10, centerY + 5);
                }
            }

            for (float y = (float)(Math.Ceiling(-visibleRangeY / 2 / step) * step); y <= visibleRangeY / 2; y += step)
            {
                int screenY = centerY - (int)(y * _skala);
                if (screenY >= 0 && screenY <= Height)
                {
                    g.DrawLine(gridPen, 0, screenY, Width, screenY);
                    g.DrawString(y.ToString(), new Font("Arial", 8), Brushes.Black, centerX + 5, screenY - 10);
                }
            }
            gridPen.Dispose();
        }

        private void Koordinatensystem_MouseWheel(object sender, MouseEventArgs e)
        {
            Zoom(e.Delta > 0 ? 1.1f : 0.9f);
        }

        private void Koordinatensystem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                Zoom(1.1f);
            }
            else if (e.KeyCode == Keys.X)
            {
                Zoom(0.9f);
            }
        }

        private void Zoom(float factor)
        {
            float oldScale = _skala;
            _skala *= factor;
            if (_skala < 1f) _skala = 1f;
            if (_skala > 200f) _skala = 200f;

            _offset.X = (int)((_offset.X) * (_skala / oldScale));
            _offset.Y = (int)((_offset.Y) * (_skala / oldScale));
            Invalidate();
        }

        private void Koordinatensystem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = true;
                _dragStart = e.Location;
            }
        }

        private void Koordinatensystem_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                _offset.X += e.X - _dragStart.X;
                _offset.Y += e.Y - _dragStart.Y;
                _dragStart = e.Location;
                Invalidate();
            }
        }

        private void Koordinatensystem_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = false;
            }
        }
    }
}
