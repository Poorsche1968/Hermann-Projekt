using FunktionZeichnen;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FunktionZeichnen
{
    public class ExponentialFunktion : Funktion
    {
        public double Base { get; set; }

        public ExponentialFunktion(double baseValue)
        {
            Base = baseValue;
        }

        public override double Berechne(double x)
        {
            return Math.Pow(Base, x);
        }
  
        public override string GetFunktionsTyp()
        {
            return "Exponential Function";
        }
    }
}

