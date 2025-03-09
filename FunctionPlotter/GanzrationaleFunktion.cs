using System;

namespace FunktionZeichnen
{
    //Klasse zur Darstellung einer allgemeinen Ganzrationalefunktion
    public class GanzrationaleFunktion : Funktion
    {
        #region Eigenschaften

        //Array zur Speicherung der Koeffizienten der Ganzrationalen Funktion
        private double[] _koeffizienten;

        #endregion

        #region Konstruktor

        //Initialisiert die Ganzrationale Funktion mit den gegebenen Koeffizienten
        public GanzrationaleFunktion(double[] koeffizienten)
        {
            _koeffizienten = koeffizienten;
        }

        #endregion

        #region Methoden

        //Berechnet den Funktionswert an einer bestimmten Stelle x
        public override double Berechne(double x)
        {
            double ergebnis = 0;

            //Iteriert über alle Koeffizienten und berechnet den Funktionswert mit der Potenzregel für Polynome
            for (int i = 0; i < _koeffizienten.Length; i++)
            {
                //Berechnung des Funktionswerts mit der Potenzregel: a_n * x^n + a_(n-1) * x^(n-1) + ... + a_1 * x + a_0
                ergebnis += _koeffizienten[i] * Math.Pow(x, _koeffizienten.Length - 1 - i);
            }

            return ergebnis;
        }

        //Gibt den Funktionstyp als String zurück
        public override string AuswhalFunktionsTyp()
        {
            return "Ganzrationale Funktion"; //Rückgabe der Bezeichnung der Funktion
        }

        #endregion
    }
}
