using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS1_06_LE_04_01
{
    /// <summary>
    /// Abstrakte Basisklasse für geometrische Figuren.
    /// </summary>
    public abstract class GeometrischeFigur
    {
        /// <summary>
        /// Der Wert von Pi.
        /// </summary>
        public const double Pi = 3.14159265;// Konstante für den Wert von Pi

        /// <summary>
        /// Die Höhe der geometrischen Figur.
        /// </summary>
        public double Hohe { get; set; }// Eigenschaft(Property) für die Höhe

        /// <summary>
        /// Der Radius der geometrischen Figur.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Die Länge der Seite A der geometrischen Figur.
        /// </summary>
        public double SeitenA { get; set; }

        /// <summary>
        /// Die Länge der Seite B der geometrischen Figur.
        /// </summary>
        public double SeitenB { get; set; }

        /// <summary>
        /// Die Länge der Seite C der geometrischen Figur.
        /// </summary>
        public double SeitenC { get; set; }

        /// <summary>
        /// Die Farbe der geometrischen Figur.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Berechnet die Fläche der geometrischen Figur.
        /// </summary>
        /// <returns>Die Fläche der geometrischen Figur</returns>
        public abstract double BerechneFlaeche();

        /// <summary>
        /// Berechnet den Umfang der geometrischen Figur.
        /// </summary>
        /// <returns>Der Umfang der geometrischen Figur.</returns>
        public abstract double BerechneUmfang(); 
        
    }
}
