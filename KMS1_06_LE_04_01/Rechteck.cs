using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS1_06_LE_04_01
{
    /// <summary>
    /// Repräsentiert ein Rechteck als geometrische Figur.
    /// </summary>
    public class Rechteck : GeometrischeFigur
    {
        /// <summary>
        /// Berechnet die Fläche des Rechtecks.
        /// </summary>
        /// <returns>Die Fläche des Rechtecks.</returns>
        public override double BerechneFlaeche() => SeitenA * SeitenB;

        /// <summary>
        /// Berechnet den Umfang des Rechtecks.
        /// </summary>
        /// <returns>Der Umfang des Rechtecks.</returns>
        public override double BerechneUmfang() => 2*SeitenA + 2*SeitenB;
    }
}
