using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunktionZeichnen
{
    public class LineareFunktion : Funktion
    {
        public double Neigung { get; set; }
        public double Abfangen { get; set; }

        public LineareFunktion(double neigung, double abfangen)
        {
            Neigung = neigung;
            Abfangen = abfangen;
        }

        public override double Berechne(double x)
        {
            return Neigung * x + Abfangen;
        }

        public override string GetFunktionsTyp()
        {
            return "Lineare Funktion";
        }
    }
}