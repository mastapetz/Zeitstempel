using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufteilen
{
    internal class Personen
    {
        public Dictionary<string, double> Schulden;

        ////Properties
        public string Name { get; set; }
        public double Betrag { get; set; }

        // Konstruktor
        //public Personen(string name, double betrag)
        //{
        //    this.Name = name;
        //    this.Betrag = betrag;
        //}

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
                double betrag = double.Parse(parts[0]);
                gesamtAusgaben += betrag;
            }

            // Durchschnitt berechnen
            double durchschnitt = gesamtAusgaben / lines.Length;

            // Ausgaben pro person Berechnen 
            foreach (string line in lines)
            {
                // Aufteilen
                string[] parts = line.Split(';');
                string name = parts[1];
                double betrag = double.Parse(parts[0]);

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


    }
}
