using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS1_06_LE_04_01
{
    internal class Menu
    {
        /// <summary>
        /// Die Lieste zum Speichern der Ergebnisse von Berechnungen, jedoch nicht als Klasse vom GeometrischeFigur, sondern als String
        /// </summary>
        List<string> history = new List<string>();

        /// <summary>
        /// Zeigt das Hauptmenü an und verarbeitet die Benutzereingaben.
        /// </summary>
        public void PrintMenu()
        {
            bool exit = false;
            while (!exit) 
            {
                Console.WriteLine("\n*** Rechner für Flaeche und Umfang ***\n[0] Programm beenden\n[1] Berechne Kreis\n[2] Berechne Rechteck \n[3] Berechne Dreieck\n[4] Geschichte der Berechnungen");  
                switch (InputNumber("Geben Sie den Index Ihrer Wahl ein: "))
                {
                    case 0:exit = true; break;
                    case 1: PrintHelpMenu("Kreis"); break;// Hilfemenü für Kreis anzeigen
                    case 2: PrintHelpMenu("Rechteck"); break;// Hilfemenü für Rechteck anzeigen
                    case 3: PrintHelpMenu("Dreieck"); break;// Hilfemenü für Dreieck anzeigen
                    case 4:PrintHistory(); break;
                    default: Console.WriteLine("\n--- Geben Sie nur den Index von 0-4 ein ---\n");break;
                }
            }
        }

        /// <summary>
        /// Zeigt das Hilfe Menü an und verarbeitet die Benutzereingaben.
        /// </summary>
        /// <param name="option">Die option vom Hauptmenü</param>
        private void PrintHelpMenu(string option)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine($"\n*** Rechner für {option} ***\n[0] Züruck Haupt Menu\n[1] Berechne Flaeche\n[2] Berechne Umfang");
                switch (InputNumber("Geben Sie den Index Ihrer Wahl ein: "))
                {
                    case 0: exit = true; break;// Zurück zum Hauptmenü
                    case 1:
                        switch (option)
                        {
                            case "Kreis": BerechneKreis("Flaeche"); break;// Fläche des Kreises berechnen
                            case "Rechteck": BerechneRechteck("Flaeche"); break;
                            case "Dreieck": BerechneDreieck("Flaeche"); break;
                        }
                        break;
                    case 2:
                        switch (option)
                        {
                            case "Kreis": BerechneKreis("Umfang"); break;// Umfang des Kreises berechnen
                            case "Rechteck": BerechneRechteck("Umfang"); break;
                            case "Dreieck": BerechneDreieck("Umfang"); break;
                        } 
                        break;
                    default: Console.WriteLine("\n--- Geben Sie nur den Index von 0-2 ein ---\n"); break;
                }
            }
        }

        /// <summary>
        /// Berechnet die Fläche oder den Umfang eines Kreises basierend auf der angegebenen Option.
        /// </summary>
        /// <param name="option">Die Option, die berechnet werden soll (Fläche oder Umfang).</param>
        private void BerechneKreis(string option)
        {
            GeometrischeFigur kreis = new Kreis();// Instanz eines Kreises erstellen
            kreis.Radius = InputDouble("Bitte geben Sie Radius ein (cm): "); // Radius vom Benutzer eingeben lassen
            switch (option)
            {
                case "Flaeche":               
                    double result = kreis.BerechneFlaeche();// Fläche des Kreises berechnen
                    Console.WriteLine($"Flaeche is {result:F2} cm²");// Ergebnis anzeigen mit zwei decimal nummer
                    history.Add($"Kreis - Fläche: 3,14 * {kreis.Radius}² = {result:F2} cm²");
                    break;
                case "Umfang":
                    result = kreis.BerechneUmfang();
                    Console.WriteLine($"Flaeche is {result:F2} cm");
                    history.Add($"Kreis - Umfang: 2 * 3,14 * {kreis.Radius} = {result:F2} cm");
                    break;  
            }
        }

        /// <summary>
        /// Berechnet die Fläche oder den Umfang eines Rechtecks basierend auf der angegebenen Option.
        /// </summary>
        /// <param name="option">Die Option, die berechnet werden soll (Fläche oder Umfang).</param>
        private void BerechneRechteck(string option)
        {
            GeometrischeFigur rechteck = new Rechteck();// Instanz eines Rechtecks erstellen
            rechteck.SeitenA = InputDouble("Bitte geben Sie Seiten A ein (cm): ");// Länge der Seite A vom Benutzer eingeben lassen
            rechteck.SeitenB = InputDouble("Bitte geben Sie Seiten B ein (cm): ");// Länge der Seite B vom Benutzer eingeben lassen
            switch (option)
            {
                case "Flaeche":
                    double result = rechteck.BerechneFlaeche();// Fläche des Rechtecks berechnen
                    Console.WriteLine($"Flaeche is {result} cm²");// Ergebnis anzeigen
                    history.Add($"Rechteck - Fläche: {rechteck.SeitenA} * {rechteck.SeitenB} = {result} cm²");
                    break;
                case "Umfang":
                    result = rechteck.BerechneUmfang();
                    Console.WriteLine($"Flaeche is {result} cm");
                    history.Add($"Rechteck - Umfang: 2 * {rechteck.SeitenA} + 2 * {rechteck.SeitenB} = {result} cm");
                    break;
            }
        }

        /// <summary>
        /// Berechnet die Fläche oder den Umfang eines Dreiecks basierend auf der angegebenen Option.
        /// </summary>
        /// <param name="option">Die Option, die berechnet werden soll (Fläche oder Umfang).</param>
        private void BerechneDreieck(string option)
        {
            GeometrischeFigur dreieck = new Dreieck();// Instanz eines Dreiecks erstellen
            dreieck.SeitenA = InputDouble("Bitte geben Sie Seiten A ein (cm): ");// Länge der Seite A vom Benutzer eingeben lassen
            switch (option)
            {
                case "Flaeche":
                    dreieck.Hohe = InputDouble("Bitte geben Sie Höhe ein (cm): ");// Höhe vom Benutzer eingeben lassen
                    double result = dreieck.BerechneFlaeche();// Fläche des Dreiecks berechnen
                    Console.WriteLine($"Flaeche is {result} cm²");// Ergebnis anzeigen
                    history.Add($"Dreieck - Fläche: ({dreieck.SeitenA} * {dreieck.Hohe}) / 2 = {result} cm²");
                    break;
                case "Umfang":
                    dreieck.SeitenB = InputDouble("Bitte geben Sie Seiten B ein (cm): ");
                    dreieck.SeitenC = InputDouble("Bitte geben Sie Seiten C ein (cm): ");
                    result = dreieck.BerechneUmfang();
                    Console.WriteLine($"Flaeche is {result} cm");
                    history.Add($"Dreieck - Umfang: {dreieck.SeitenA} + {dreieck.SeitenB} + {dreieck.SeitenC} = {result} cm");
                    break;
            }
        }

        /// <summary>
        /// Zeigt die Berechnungsgeschichte an.
        /// </summary>
        private void PrintHistory()
        {
            if (history.Count == 0)
            {
                Console.WriteLine("\nKeine Berechnungshistorie verfügbar.\n");
                return;
            }

            // Schleife durch die Liste der historischen Ergebnisse
            foreach (var result in history)
            {
                // Historischen Eintrag anzeigen
                Console.WriteLine(result);
            }
        }

        /// <summary>
        /// Liest eine Ganzzahl vom Benutzer ein und stellt sicher, dass die Eingabe nicht leer ist.
        /// </summary>
        /// <param name="prompt">Die Anzeigeaufforderung.</param>
        /// <returns>Die Benutzereingabe als Ganzzahl.</returns>
        private int InputNumber(string prompt)
        {
            int number;
            while (true)
            {
                Console.WriteLine($"\n{prompt}");// Anzeige der Eingabeaufforderung an den Benutzer
                string input = Console.ReadLine();// Benutzereingabe lesen
                if (string.IsNullOrEmpty(input) )
                {
                    Console.WriteLine("\n--- Eingabe darf nicht leer sein ---\n");
                    continue;// Schleife fortsetzen, wenn die Eingabe leer ist
                }
                try
                {
                    number = Convert.ToInt32(input);// Versuch, die Eingabe in eine Ganzzahl zu konvertieren
                    break;// Schleife unterbrechen, wenn die Konvertierung erfolgreich is
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n--- Geben Sie nur eine Ganzzahl ein ---\n" + e.Message);
                }
            }         
            return number;// Rückgabe der Ganzzahl
        }

        /// <summary>
        /// Liest eine Dezimalzahl vom Benutzer ein und stellt sicher, dass die Eingabe nicht leer ist und ist größer als Null.
        /// </summary>
        /// <param name="prompt">Die Anzeigeaufforderung.</param>
        /// <returns>Die Benutzereingabe als Dezimalzahl.</returns>
        private double InputDouble(string prompt)
        {
            double number;
            while (true)
            {
                Console.WriteLine($"\n{prompt}");// Anzeige der Eingabeaufforderung an den Benutzer
                string input = Console.ReadLine();// Benutzereingabe lesen

                if (string.IsNullOrWhiteSpace(input))
                {
                    // Fehler, wenn die Eingabe leer ist
                    Console.WriteLine("\n--- Eingabe darf nicht leer sein ---\n");
                    continue; // Schleife fortsetzen, wenn die Eingabe leer ist
                }

                try
                {
                    number = Convert.ToDouble(input);// Versuch, die Eingabe in eine Dezimalzahl zu konvertieren
                    if (number > 0) { break; }else { Console.WriteLine("Die Zahl muss größer als Null sein"); }  // Kontrole Zahl fur Null            
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n--- Geben Sie nur eine Dezimalzahl ein ---\n" + e.Message);
                }
            }
            return number;// Rückgabe der Dezimalzahl
        }
    }
}
