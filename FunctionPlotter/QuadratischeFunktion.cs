using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunktionZeichnen
{
    // Klasse zur Darstellung einer quadratischen Funktion
    public class QuadratischeFunktion : Funktion
    {
        // Eigenschaften für die Koeffizienten der quadratischen Funktion
        public double A { get; set; } // Koeffizient für x^2
        public double B { get; set; } // Koeffizient für x
        public double C { get; set; } // Konstanter Term

        // Konstruktor zum Initialisieren der Koeffizienten
        public QuadratischeFunktion(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        // Methode zur Berechnung des Funktionswerts für ein gegebenes x
        public override double Berechne(double x)
        {
            return A * x * x + B * x + C;// Berechnung der quadratischen Funktion: ax^2 + bx + c
        }

        // Methode zur Rückgabe des Funktionstyps als String
        public override string GetFunktionsTyp()
        {
            return "Quadratic Function";// Gibt den Namen des Funktionstyps zurück
        }

        // Methode zur Berechnung der Nullstellen (Wurzeln) der quadratischen Funktion
        public double[] BerechneWurzeln()
        {
            double diskriminante = B * B - 4 * A * C; // Berechnung der Diskriminante: D = b^2 - 4ac
            if (diskriminante < 0) return new double[0]; // Falls die Diskriminante negativ ist, gibt es keine reellen Wurzeln

            // Berechnung der beiden Wurzeln mit der Mitternachtsformel (quadratische Lösungsformel)
            double wurzel1 = (-B + Math.Sqrt(diskriminante)) / (2 * A);
            double wurzel2 = (-B - Math.Sqrt(diskriminante)) / (2 * A);

            return new double[] { wurzel1, wurzel2 };// Rückgabe der berechneten Nullstellen
        }
    }
}