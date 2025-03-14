﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace FunktionZeichnen
{
    
    public partial class Koordinatensystem : Panel
    {
        #region Felder und Eigenschaften
        private Funktion _funktion;                     // Speichert die aktuelle Funktion
        private float _skala = 20f;                     // Skalierungsfaktor für die Darstellung der Funktion
        private Point _offset = new Point(0, 0);        // Offset für das Verschieben des Koordinatensystems
        private Button zoomInButton;                    // Button zum Hineinzoomen
        private Button zoomOutButton;                   // Button zum Herauszoomen
        #endregion

        #region Panel-Eigenschaften festlegen
        public Koordinatensystem()
        {

            InitializeComponent();
            DoubleBuffered = true;                      // Doppeltes Puffern aktivieren
            BackColor = Color.White;                    // Hintergrundfarbe festlegen
            BorderStyle = BorderStyle.FixedSingle;      // Rahmenstil festlegen


            // Maus- und Tastatur-Events zuweisen
            this.MouseWheel += Koordinatensystem_MausRad;          // Zoom-Funktionalität beim Scrollen
            this.Focus();                                          // Fokus auf das Panel setzen

            // Buttons zum Zoomen hinzufügen
            zoomInButton = new Button { Text = "+", Location = new Point(10, 10), Size = new Size(30, 30) };    // Button zum Hineinzoomen
            zoomOutButton = new Button { Text = "-", Location = new Point(50, 10), Size = new Size(30, 30) };   // Button zum Herauszoomen
            zoomInButton.Click += (s, e) => Zoom(1.1f);                                                         // Hineinzoomen
            zoomOutButton.Click += (s, e) => Zoom(0.9f);                                                        // Herauszoomen
            this.Controls.Add(zoomInButton);                                                                    // Button zum Panel hinzufügen (In)
            this.Controls.Add(zoomOutButton);                                                                   // Button zum Panel hinzufügen (out)
        }
        #endregion

        #region Methoden für die Funktionalität
        public void SetzeFunktion(Funktion funktion)
        {
            _funktion = funktion;                   // Funktion speichern
            _skala = 20f;                           // Skalierung zurücksetzen
            _offset = new Point(0, 0);              // Offset zurücksetzen
            Invalidate();                           // Neuzeichnen des Panels
        }
        #endregion

        #region Zeichenmethoden
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);                                      // Basisklasse aufrufen
            if (_funktion == null) return;                        // Funktion muss gesetzt sein

            Graphics g = e.Graphics;                              // Grafikobjekt für das Zeichnen
            Pen achsenstift = new Pen(Color.Black, 2);            // Stift für die Achsen
            Pen funktionStift = new Pen(Color.Blue, 2);           // Stift für die Funktion

            int mitteX = Width / 2 + _offset.X;                  // Mittelpunkt der x-achsen im Panel
            int mitteY = Height / 2 + _offset.Y;                 // Mittelpunkt der y-Achse im Panel

            // Achsen zeichnen
            g.DrawLine(achsenstift, mitteX, 0, mitteX, Height);       // y-Achse 
            g.DrawLine(achsenstift, 0, mitteY, Width, mitteY);        // x-Achse

            // Achsenbeschriftung und Raster zeichnen
            float schritt = schrittweiteBerechnen();                            // Schrittweite für die Achsenbeschriftung
            achsenbeschriftungenZeichnen(g, mitteX, mitteY, schritt);          // Achsenbeschriftung und Raster zeichnen   

            // Min- und Max-Werte für die Funktion berechnen
            float minX = -Width / (2 * _skala) - _offset.X / _skala;        // Min-Wert für x-Achse 
            float maxX = Width / (2 * _skala) - _offset.X / _skala;         // Max-Wert für x-Achse
            PointF? vorherigerPunkt = null;                                 // Vorheriger Punkt für Linienverbindung

            // Funktion zeichnen
            for (float x = minX; x <= maxX; x += 0.1f)                                              // Schrittweite von 0.1
            {
                float y = (float)_funktion.Berechne(x);                                             // Funktionswert berechnen
                if (float.IsInfinity(y) || float.IsNaN(y) || Math.Abs(y) > Height * 10)             // Falls der y-Wert ungültig ist, keine Linie zeichnen
                {
                    vorherigerPunkt = null;                                                         // Vorherigen Punkt zurücksetzen
                    continue;                                                                       // Nächster Schritt
                }

                float screenX = mitteX + x * _skala;                                               // x-Wert in Bildschirmkoordinaten umrechnen
                float screenY = mitteY - y * _skala;                                               // y-Wert in Bildschirmkoordinaten umrechnen        

                if (vorherigerPunkt != null)                                                          // Linie zeichnen, wenn ein vorheriger Punkt vorhanden ist
                {
                    g.DrawLine(funktionStift, vorherigerPunkt.Value, new PointF(screenX, screenY));   // Linie zeichnen
                }
                vorherigerPunkt = new PointF(screenX, screenY);                                       // Vorherigen Punkt speichern
            }

            // Stifte freigeben
            achsenstift.Dispose();           // Stift für die Achsen freigeben
            funktionStift.Dispose();         // Stift für die Funktion freigeben
        }
        #endregion

        #region Interaktion mit dem Benutzer (Zoom, Verschieben)
        private float schrittweiteBerechnen()
        {
            float[] schrittweiten = { 1, 2, 5, 10, 20, 50, 100 };                   // Mögliche Schrittweiten
            float idealeSchrittweite = Width / (_skala * 10);                       // Ideale Schrittweite
            foreach (float schrittweite in schrittweiten)                           // Nächste Schrittweite finden
            {
                if (idealeSchrittweite < schrittweite) return schrittweite;         // Nächste Schrittweite verwenden
            }
            return 100;  // Standard-Schrittweite
        }
        #endregion

        #region Zeichnet die Achsenbeschriftungen und das Raster
        private void achsenbeschriftungenZeichnen(Graphics g, int zentrumX, int zentrumY, float schrittweite)        // Achsenbeschriftung und Raster zeichnen               
        {
            float sichtbarerBereichX = Width / _skala;                                                               // Sichtbarer Bereich der x-Achse
            float sichtbarerBereichY = Height / _skala;                                                              // Sichtbarer Bereich der y-Achse
            Pen rasterStift = new Pen(Color.LightGray, 1);                                                           // Stift für das Raster

            // x-Achsen-Beschriftung und Rasterlinien
            for (float x = (float)(Math.Ceiling(-sichtbarerBereichX / 2 / schrittweite) * schrittweite); x <= sichtbarerBereichX / 2; x += schrittweite)// Schrittweite für die x-Achsen-Beschriftung
            {
                int screenX = zentrumX + (int)(x * _skala);                              // x-Wert in Bildschirmkoordinaten umrechnen
                if (screenX >= 0 && screenX <= Width)                                    // Nur zeichnen, wenn der Punkt sichtbar ist
                {
                    g.DrawLine(rasterStift, screenX, 0, screenX, Height);                                                            // Rasterlinie zeichnen
                    g.DrawString(x.ToString(), new Font("Arial", 8), Brushes.Black, screenX - 10, zentrumY + 5);                     // Achsenbeschriftung zeichnen
                }
            }

            // y-Achsen-Beschriftung und Rasterlinien
            for (float y = (float)(Math.Ceiling(-sichtbarerBereichY / 2 / schrittweite) * schrittweite); y <= sichtbarerBereichY / 2; y += schrittweite)// Schrittweite für die y-Achsen-Beschriftung
            {
                int screenY = zentrumY - (int)(y * _skala);                                                                         // y-Wert in Bildschirmkoordinaten umrechnen
                if (screenY >= 0 && screenY <= Height)                                                                              // Nur zeichnen, wenn der Punkt sichtbar ist
                {
                    g.DrawLine(rasterStift, 0, screenY, Width, screenY);                                                            // Rasterlinie zeichnen
                    g.DrawString(y.ToString(), new Font("Arial", 8), Brushes.Black, zentrumX + 5, screenY - 10);                    // Achsenbeschriftung zeichnen  
                }
            }
            rasterStift.Dispose();        // Stift für das Raster freigeben
        }
        #endregion

        #region Zoom-Funktionalität beim Scrollen mit der Maus
        private void Koordinatensystem_MausRad(object sender, MouseEventArgs e)
        {
            Zoom(e.Delta > 0 ? 1.1f : 0.9f);        // Zoom-Faktor anhand des Mausrads festlegen
        }
        #endregion

        #region Verschieben des Koordinatensystems 
        private void Zoom(float faktor)
        {
            float alteSkala = _skala;               // Alte Skalierung speichern
            _skala *= faktor;                       // Neue Skalierung festlegen
            if (_skala < 1f) _skala = 1f;           // Mindestgröße festlegen
            if (_skala > 200f) _skala = 200f;       // Maximalgröße festlegen

            
            _offset.X = (int)((_offset.X) * (_skala / alteSkala));       // Offset für x-Achse anpassen
            _offset.Y = (int)((_offset.Y) * (_skala / alteSkala));       // Offset für y-Achse anpassen
            Invalidate();                                                // Neuzeichnen des Panels
        }
        #endregion

    }
}
