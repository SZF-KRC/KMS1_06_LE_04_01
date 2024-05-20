using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS1_06_LE_04_01
{
    public abstract class GeometrischeFigur
    {
        public double Radius { get; set; }
        public double SeitenA { get; set; }
        public double SeitenB { get; set; }

        public double SeitenC { get; set; }
        public string Color { get; set; }


        public abstract double CalculateArea();


        public abstract double CalculatePerimeter(); 
        
    }
}
