using System;
using System.Drawing;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    #region Klasse für das Koordinatensystem
    public partial class Koordinatensystem : Panel
    {
        #region Felder und Eigenschaften
        private Funktion _funktion;                     // Speichert die aktuelle Funktion
        private float _skala = 20f;                    // Skalierungsfaktor für die Darstellung der Funktion
        private Point _offset = new Point(0, 0);      // Offset für das Verschieben des Koordinatensystems
        private Point _ziehenStart;                  // Startpunkt für das Ziehen der Ansicht mit der Maus
        private bool _ziehen = false;               // Gibt an, ob die Mausbewegung aktuell das System verschiebt
        private Button zoomInButton;               // Button zum Hineinzoomen
        private Button zoomOutButton;             // Button zum Herauszoomen
        #endregion

        #region Panel-Eigenschaften festlegen
        public Koordinatensystem()
        {

            InitializeComponent();
            DoubleBuffered = true;                      // Doppeltes Puffern aktivieren
            BackColor = Color.White;                   // Hintergrundfarbe festlegen
            BorderStyle = BorderStyle.FixedSingle;    // Rahmenstil festlegen


            // Maus- und Tastatur-Events zuweisen
            this.MouseWheel += Koordinatensystem_MouseWheel;        // Zoom-Funktionalität beim Scrollen
            this.Focus();                                         // Fokus auf das Panel setzen

            // Buttons zum Zoomen hinzufügen
            zoomInButton = new Button { Text = "+", Location = new Point(10, 10), Size = new Size(30, 30) };    // Button zum Hineinzoomen
            zoomOutButton = new Button { Text = "-", Location = new Point(50, 10), Size = new Size(30, 30) };  // Button zum Herauszoomen
            zoomInButton.Click += (s, e) => Zoom(1.1f);                                                       // Hineinzoomen
            zoomOutButton.Click += (s, e) => Zoom(0.9f);                                                     // Herauszoomen
            this.Controls.Add(zoomInButton);                                                                // Button zum Panel hinzufügen (In)
            this.Controls.Add(zoomOutButton);                                                              // Button zum Panel hinzufügen (out)
        }
        #endregion

        #region Methoden für die Funktionalität
        public void SetFunktion(Funktion funktion)
        {
            _funktion = funktion;                   // Funktion speichern
            _skala = 20f;                          // Skalierung zurücksetzen
            _offset = new Point(0, 0);            // Offset zurücksetzen
            Invalidate();                        // Neuzeichnen des Panels
        }
        #endregion

        #region Zeichenmethoden
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);                                        // Basisklasse aufrufen
            if (_funktion == null) return;                         // Funktion muss gesetzt sein

            Graphics g = e.Graphics;                              // Grafikobjekt für das Zeichnen
            Pen axisPen = new Pen(Color.Black, 2);               // Stift für die Achsen
            Pen functionPen = new Pen(Color.Blue, 2);           // Stift für die Funktion

            int centerX = Width / 2 + _offset.X;                  // Mittelpunkt der x-achsen im Panel
            int centerY = Height / 2 + _offset.Y;                // Mittelpunkt der y-Achse im Panel

            // Achsen zeichnen
            g.DrawLine(axisPen, centerX, 0, centerX, Height);       // y-Achse 
            g.DrawLine(axisPen, 0, centerY, Width, centerY);        // x-Achse

            // Achsenbeschriftung und Raster zeichnen
            float step = CalculateDynamicStep();                // Schrittweite für die Achsenbeschriftung
            DrawAxisLabels(g, centerX, centerY, step);          // Achsenbeschriftung und Raster zeichnen   

            // Min- und Max-Werte für die Funktion berechnen
            float minX = -Width / (2 * _skala) - _offset.X / _skala;        // Min-Wert für x-Achse
            float maxX = Width / (2 * _skala) - _offset.X / _skala;         // Max-Wert für x-Achse
            PointF? previousPoint = null;                                   // Vorheriger Punkt für Linienverbindung

            // Funktion zeichnen
            for (float x = minX; x <= maxX; x += 0.1f)                                              // Schrittweite von 0.1
            {
                float y = (float)_funktion.Berechne(x);                                             // Funktionswert berechnen
                if (float.IsInfinity(y) || float.IsNaN(y) || Math.Abs(y) > Height * 10)             // Falls der y-Wert ungültig ist, keine Linie zeichnen
                {
                    previousPoint = null;                                                           // Vorherigen Punkt zurücksetzen
                    continue;                                                                       // Nächster Schritt
                }

                float screenX = centerX + x * _skala;                                               // x-Wert in Bildschirmkoordinaten umrechnen
                float screenY = centerY - y * _skala;                                               // y-Wert in Bildschirmkoordinaten umrechnen        

                if (previousPoint != null)                                                          // Linie zeichnen, wenn ein vorheriger Punkt vorhanden ist
                {
                    g.DrawLine(functionPen, previousPoint.Value, new PointF(screenX, screenY));     // Linie zeichnen
                }
                previousPoint = new PointF(screenX, screenY);                                       // Vorherigen Punkt speichern
            }

            // Ressourcen freigeben
            axisPen.Dispose();              // Stift für die Achsen freigeben
            functionPen.Dispose();         // Stift für die Funktion freigeben
        }
        #endregion

        #region Interaktion mit dem Benutzer (Zoom, Verschieben)
        private float CalculateDynamicStep()
        {
            float[] steps = { 1, 2, 5, 10, 20, 50, 100 };           // Mögliche Schrittweiten
            float idealStep = Width / (_skala * 10);                // Ideale Schrittweite
            foreach (float step in steps)                           // Nächste Schrittweite finden
            {
                if (idealStep < step) return step;                  // Nächste Schrittweite verwenden
            }
            return 100;                                             // Standard-Schrittweite
        }
        #endregion

        #region Zeichnet die Achsenbeschriftungen und das Raster
        private void DrawAxisLabels(Graphics g, int centerX, int centerY, float step)                       // Achsenbeschriftung und Raster zeichnen               
        {
            float visibleRangeX = Width / _skala;                                                           // Sichtbarer Bereich der x-Achse
            float visibleRangeY = Height / _skala;                                                          // Sichtbarer Bereich der y-Achse
            Pen gridPen = new Pen(Color.LightGray, 1);                                                      // Stift für das Raster

            // x-Achsen-Beschriftung und Rasterlinien
            for (float x = (float)(Math.Ceiling(-visibleRangeX / 2 / step) * step); x <= visibleRangeX / 2; x += step)              // Schrittweite für die x-Achsen-Beschriftung
            {
                int screenX = centerX + (int)(x * _skala);                                                                          // x-Wert in Bildschirmkoordinaten umrechnen
                if (screenX >= 0 && screenX <= Width)                                                                               // Nur zeichnen, wenn der Punkt sichtbar ist
                {
                    g.DrawLine(gridPen, screenX, 0, screenX, Height);                                                               // Rasterlinie zeichnen
                    g.DrawString(x.ToString(), new Font("Arial", 8), Brushes.Black, screenX - 10, centerY + 5);                     // Achsenbeschriftung zeichnen
                }
            }

            // y-Achsen-Beschriftung und Rasterlinien
            for (float y = (float)(Math.Ceiling(-visibleRangeY / 2 / step) * step); y <= visibleRangeY / 2; y += step)              // Schrittweite für die y-Achsen-Beschriftung
            {
                int screenY = centerY - (int)(y * _skala);                                                                          // y-Wert in Bildschirmkoordinaten umrechnen
                if (screenY >= 0 && screenY <= Height)                                                                              // Nur zeichnen, wenn der Punkt sichtbar ist
                {
                    g.DrawLine(gridPen, 0, screenY, Width, screenY);                                                                // Rasterlinie zeichnen
                    g.DrawString(y.ToString(), new Font("Arial", 8), Brushes.Black, centerX + 5, screenY - 10);                     // Achsenbeschriftung zeichnen  
                }
            }
            gridPen.Dispose();        // Stift für das Raster freigeben
        }
        #endregion

        #region Zoom-Funktionalität beim Scrollen mit der Maus
        private void Koordinatensystem_MouseWheel(object sender, MouseEventArgs e)
        {
            Zoom(e.Delta > 0 ? 1.1f : 0.9f);        // Zoom-Faktor anhand des Mausrads festlegen
        }
        #endregion

        #region Verschieben des Koordinatensystems 
        private void Zoom(float factor)
        {
            float oldScale = _skala;                // Alte Skalierung speichern
            _skala *= factor;                       // Neue Skalierung festlegen
            if (_skala < 1f) _skala = 1f;           // Mindestgröße festlegen
            if (_skala > 200f) _skala = 200f;       // Maximalgröße festlegen

            
            _offset.X = (int)((_offset.X) * (_skala / oldScale));       // Offset für x-Achse anpassen
            _offset.Y = (int)((_offset.Y) * (_skala / oldScale));       // Offset für y-Achse anpassen
            Invalidate();           // Neuzeichnen des Panels
        }
        #endregion

    }
}
#endregion