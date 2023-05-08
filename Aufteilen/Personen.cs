using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufteilen
{
    internal class Personen
    {

        // Properties
        public string Name { get; set; }
        public double Betrag { get; set; }
        public Dictionary<string, double> Schulden { get; set; }

        // Konstruktor
        public Personen(string name, double betrag)
        {
            Name = name;
            Betrag = betrag;
            // Dictionary damit mit den Werten besser gearbeitet werden kann
            Schulden = new Dictionary<string, double>();
        }

        // Ausgabe
        public override string ToString()
        {
            string result = $"Name: {Name} Betrag am Anfang {Betrag:F2} \n";
            foreach (KeyValuePair<string, double> eintrag in Schulden)
            {
                if (eintrag.Value < 0)
                    // Wenn Betrag unter 0 in diesem Schritt => Keine Schulden
                    // gehe zum nächsten KeyValuePair
                    continue;
                else
                    // Wenn Betrag über 0 in diesem Schritt => Schulden ausgeben
                    result += $" An {eintrag.Key}  Betrag Schuldig {eintrag.Value:F2}\n";

            }

            return result;
        }
    }
}










































/*
        internal static Dictionary<string, double> ParseTXT(string path)
        {
            // Dictionary anlegen
            var Schulden = new Dictionary<string, double>();

            // File Einlesen
            string[] lines = File.ReadAllLines(path);

            // Gesamtausgaben Berechnen
            double gesamtAusgaben = 0;
            foreach (string line in lines)
            {
                // Aufteilen
                string[] parts = line.Split(';');
                double betrag = double.Parse(parts[1]);
                gesamtAusgaben += betrag;
            }

            // Durchschnitt berechnen
            double durchschnitt = gesamtAusgaben / lines.Length;

            // Ausgaben pro person Berechnen 
            foreach (string line in lines)
            {
                // Aufteilen
                string[] parts = line.Split(';');
                string name = parts[0];
                double betrag = double.Parse(parts[1]);

                double ausgaben = betrag - durchschnitt;

                // Ins dictionary speichern
                if (Schulden.ContainsKey(name))
                {
                    Schulden[name] += ausgaben;
                }
                else
                {
                    Schulden.Add(name, ausgaben);
                }

            }
            return Schulden;
        }

        public override string ToString()
        {
            string result = $"Name: {Name} Betrag {Betrag} Schulden {Schulden}";
            foreach (var derp in Schulden)
            {
                result += $"\t{derp.Key}: {derp.Value}";
            }

            return result;
        }
        */
