using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS1_06_LE_04_01
{
    public class GeometrischeFigur
    {
        public string Color { get; set; }
        public virtual void CalculateArea()
        {
            Console.WriteLine("Tu bude kod");
        }

        public virtual void CalculatePerimeter() 
        {
            Console.WriteLine("tu bude kod");
        }
    }
}
