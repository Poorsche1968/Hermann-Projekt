using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunktionZeichnen
{
    // Klasse zur Darstellung einer allgemeinen Ganzrationalefunktion
    public class GanzrationaleFunktion : Funktion
    {
        private double[] _koeffizienten;// Array zur Speicherung der Koeffizienten

        // Konstruktor: Initialisiert die Ganzrationalefunktion mit den gegebenen Koeffizienten
        public GanzrationaleFunktion(double[] koeffizienten)
        {
            _koeffizienten = koeffizienten;
        }
        
        // Methode zur Berechnung des Funktionswertes an einer bestimmten Stelle x
        public override double Berechne(double x)
        {
            double result = 0;
            for (int i = 0; i < _koeffizienten.Length; i++)
            {
                // Berechnung des Funktionswerts mit der Potenzregel für Polynome
                result += _koeffizienten[i] * Math.Pow(x, _koeffizienten.Length - 1 - i);
            }
            return result;
        }

        // Methode zur Rückgabe des Funktionstyps als String
        public override string GetFunktionsTyp()
        {
            return "Ganzrationale Funktion";// Deutsche Bezeichnung für die Funktion
        }
    }
}
