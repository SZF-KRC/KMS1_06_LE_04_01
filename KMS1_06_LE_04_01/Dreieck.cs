using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS1_06_LE_04_01
{
    /// <summary>
    /// Repräsentiert ein Dreieck als geometrische Figur.
    /// </summary>
    public class Dreieck : GeometrischeFigur
    {
        /// <summary>
        /// Berechnet die Fläche des Dreiecks.
        /// </summary>
        /// <returns>Die Fläche des Dreiecks.</returns>
        public override double BerechneFlaeche() => (SeitenA * Hohe) / 2;

        /// <summary>
        /// Berechnet den Umfang des Dreiecks.
        /// </summary>
        /// <returns>Der Umfang des Dreiecks.</returns>
        public override double BerechneUmfang() => SeitenA+SeitenB+SeitenC;
      
    }
}
