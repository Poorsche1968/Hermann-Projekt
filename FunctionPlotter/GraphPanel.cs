using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    public partial class Koordinatensystem : Panel
    {
        private Funktion _funktion;
        private float _skala = 20f; // Maßstab, sodass -10 bis 10 sichtbar ist
        private const float initialSkala = 20f; // Standardmaßstab zum Starten bei -10 bis 10
        private const float minSkala = 0.01f; // Mindestmaßstab für das Reinzoomen

        public Koordinatensystem()
        {
            DoubleBuffered = true;// Verhindert Flackern beim Zeichnen durch doppelte Pufferung (Backbuffer).
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;// Setzt den Rahmenstil auf einen einfachen festen Rahmen.

            this.MouseWheel += Koordinatensystem_MouseWheel;

            // Zoom-Buttons hinzufügen
            var reinzoomen = new Button() { Text = "+", Top = 10, Left = Width - 60, Width = 40 };
            var rauszoomen = new Button() { Text = "-", Top = 10, Left = Width - 110, Width = 40 };

            reinzoomen.Click += (s, e) =>
            {
                if (_skala > minSkala)
                {
                    _skala *= 1.1f;
                    Invalidate();
                }
            };
            rauszoomen.Click += (s, e) =>
            {
                _skala *= 0.9f;
                if (_skala < 1f) _skala = 1f; // Mindestskala, um sinnvolle Schritte zu behalten
                Invalidate();
            };

            Controls.Add(reinzoomen);
            Controls.Add(rauszoomen);
        }

        public void SetFunktion(Funktion funktion)
        {
            _funktion = funktion;
            _skala = initialSkala; // Skala zurücksetzen, sodass der Bereich -10 bis 10 sichtbar ist
            Invalidate(); // Panel neu zeichnen
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_funktion == null) return;

            Graphics g = e.Graphics;
            Pen axisPen = new Pen(Color.Black, 2);
            Pen functionPen = new Pen(Color.Blue, 2);

            // Koordinatensystem zeichnen
            int centerX = Width / 2;
            int centerY = Height / 2;
            g.DrawLine(axisPen, centerX, 0, centerX, Height); // Y-Achse
            g.DrawLine(axisPen, 0, centerY, Width, centerY); // X-Achse

            // Dynamische Schrittweiten für Achsenbeschriftungen
            float step = CalculateDynamicStep(); // Schrittweite basierend auf der Skala
            DrawAxisLabels(g, centerX, centerY, step); // Achsenbeschriftungen zeichnen

            // Dynamische Skalierung basierend auf dem Funktionsbereich
            float minX = -Width / (2 * _skala);
            float maxX = Width / (2 * _skala);

            // Funktion zeichnen
            PointF? previousPoint = null;
            for (float x = minX; x <= maxX; x += 0.1f)
            {
                float y = (float)_funktion.Berechne(x);

                // Wertebereich prüfen, um Überlauf oder unbrauchbare Punkte zu vermeiden
                if (float.IsInfinity(y) || float.IsNaN(y) || Math.Abs(y) > Height * 10)
                {
                    previousPoint = null; // Ungültigen Punkt überspringen
                    continue;
                }

                // Weltkoordinaten in Bildschirmkoordinaten transformieren
                float screenX = centerX + x * _skala;
                float screenY = centerY - y * _skala;

                if (previousPoint != null)
                {
                    g.DrawLine(functionPen, previousPoint.Value, new PointF(screenX, screenY));
                }

                previousPoint = new PointF(screenX, screenY);
            }

            // Ressourcen freigeben
            axisPen.Dispose();
            functionPen.Dispose();
        }

        private float CalculateDynamicStep()
        {
            // Berechnet eine dynamische Schrittweite (1, 2, 5, 10, 20, 50, ...)
            float rawStep = Width / (20 * _skala); // Versuche, ca. 20 Labels zu erstellen
            float magnitude = (float)Math.Pow(10, Math.Floor(Math.Log10(rawStep))); // Größte Zehnerpotenz ≤ rawStep
            float normalizedStep = rawStep / magnitude;

            if (normalizedStep <= 1) return magnitude;       // Schrittweite 1 * Zehnerpotenz
            else if (normalizedStep <= 2) return 2 * magnitude; // Schrittweite 2 * Zehnerpotenz
            else if (normalizedStep <= 5) return 5 * magnitude; // Schrittweite 5 * Zehnerpotenz
            else return 10 * magnitude;                       // Schrittweite 10 * Zehnerpotenz
        }

        private void DrawAxisLabels(Graphics g, int centerX, int centerY, float step)
        {
            float visibleRangeX = Width / _skala; // Sichtbarer Bereich in X-Koordinaten
            float visibleRangeY = Height / _skala; // Sichtbarer Bereich in Y-Koordinaten

            Pen gridPen = new Pen(Color.LightGray, 1);

            // X-Achse: Labels und Gitterlinien
            for (float x = (float)(Math.Ceiling(-visibleRangeX / 2 / step) * step); x <= visibleRangeX / 2; x += step)
            {
                x = (float)Math.Round(x / step) * step; // Runde auf die nächste sinnvolle Zahl
                int screenX = centerX + (int)(x * _skala);
                if (screenX >= 0 && screenX <= Width)
                {
                    g.DrawLine(gridPen, screenX, 0, screenX, Height); // Vertikale Gitterlinie

                    // Nur Dezimalzahlen anzeigen, wenn sichtbarer Bereich kleiner oder gleich 20 ist
                    string label = (visibleRangeX <= 20) ? x.ToString("0.##") : (Math.Round(x / 5) * 5).ToString("0");
                    g.DrawString(label, new Font("Arial", 8), Brushes.Black, screenX - 10, centerY + 5);
                }
            }

            // Y-Achse: Labels und Gitterlinien
            for (float y = (float)(Math.Ceiling(-visibleRangeY / 2 / step) * step); y <= visibleRangeY / 2; y += step)
            {
                y = (float)Math.Round(y / step) * step; // Runde auf die nächste sinnvolle Zahl
                int screenY = centerY - (int)(y * _skala);
                if (screenY >= 0 && screenY <= Height)
                {
                    g.DrawLine(gridPen, 0, screenY, Width, screenY); // Horizontale Gitterlinie

                    // Nur Dezimalzahlen anzeigen, wenn sichtbarer Bereich kleiner oder gleich 20 ist
                    string label = (visibleRangeY <= 20) ? y.ToString("0.##") : (Math.Round(y / 5) * 5).ToString("0");
                    g.DrawString(label, new Font("Arial", 8), Brushes.Black, centerX + 5, screenY - 10);
                }
            }

            gridPen.Dispose();
        }

        private void Koordinatensystem_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (_skala > minSkala)
                {
                    _skala *= 1.1f;
                }
            }
            else
            {
                _skala *= 0.9f;
                if (_skala < 1f) _skala = 1f; // Mindestskala
            }
            Invalidate();
        }
    }
}