using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS1_06_LE_04_01
{
    /// <summary>
    /// Repräsentiert einen Kreis als geometrische Figur.
    /// </summary>
    public class Kreis : GeometrischeFigur
    {
        /// <summary>
        /// Berechnet die Fläche des Kreises.
        /// </summary>
        /// <returns>Die Fläche des Kreises.</returns>
        public override double BerechneFlaeche() => Pi * (Radius * Radius);// Lambda-Ausdruck zur Berechnung der Fläche des Kreises, ich hätte return verwenden können, aber ich kürze den Code

        /// <summary>
        /// Berechnet den Umfang des Kreises.
        /// </summary>
        /// <returns>Der Umfang des Kreises.</returns>
        public override double BerechneUmfang() => 2*Pi*Radius;// Lambda-Ausdruck zur Berechnung des Umfangs des Kreises, ich hätte return verwenden können, aber ich kürze den Code

    }
}
