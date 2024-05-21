using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS1_06_LE_04_01
{
    
    internal class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt des Programms, der die Aufgabe hat, das Menü zu starten
        /// </summary>
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.PrintMenu();
        }
    }
}
