/*

// Eine Runde Freunde macht gemeinsam einen Urlaub
// Dabei zahlen einzelne immer für die ganze Gruppe
// Jeder der etwas zahlt, schreibt die Zahlung mit und addiert am Ende des
// Urlaubes seine Ausgaben zu einer Gesamtsumme.
// Am Ende des Urlaubes wird ein Textfile erstellt, das die
// Namen und die Summe der Ausgaben pro Person enthält
// 
// Aufgabe:

// - Einlesen des Textfiles (Format kann selbst gewählt werden)
// - Berechung eines Durchschnitts
// - Aufteilen der Ausgaben zwischen den Personen,

//   so dass nach der Aufteilung alle ausgeglichen sind

// - Für die Implementierung können beliebige Datenstrukturen gewählt werden

// Liste mit Personen
// Pro Person gibt es eine Liste von Einträgen die er anderen schuldet

// Beispiel:
// Mittel: 725
//* Name: Peter Betrag am Anfang: 1000
//* Name: Mary Betrag am Anfang: 1500
//* Name: Fritz Betrag am Anfang: 100, An Peter Betrag schuldig: 275, an Mary Betrag schuldig: 350
//* Name: Franz Betrag am Anfang: 300, An Mary Betrag schuldig: 425


 */
namespace Aufteilen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../urlaub.txt";

            // Einlesen des Textfiles
            // Abspeichern als Array
            string[] lines = File.ReadAllLines(path);

            // Liste erstellen
            List<Personen> urlaub = new List<Personen>();

            foreach (string line in lines)

            {
                // Aufteilen
                string[] parts = line.Split(';');
                string name = parts[0];
                double betrag = double.Parse(parts[1]);

                urlaub.Add(new Personen(name, betrag)); // muss als neues Objekt (?) in Liste geschrieben werden
            }

            /*
             * Lamda Operator:
             * Linke Seite: ziffer; verwendet für jedes element in der Liste urlaub steht
             * welches von der Summierungs Methode verwendet wird.
             * Rechte Seite: Die Bedingung, die jedes Element Erfüllen muss um in die Summierung aufgenommen zu werden
             * Hier: Es muss eine Zahl vom Datentyp Double vorhanden sein
             * 
             */
            double durchschnitt = urlaub.Sum(ziffer => ziffer.Betrag) / urlaub.Count;

            /*
             * Lange Vairante:
             * double urlaubSumme = 0;
             * foreach (Person eintrag in urlaub)
             * {
             *      urlaubSumme += eintrag.Betrag;
             *  }
             *  double durchschnitt = sum / urlaub.Count;
             */

            // Aufteilen der Ausgaben zwischen den Personen
            foreach (Personen person in urlaub)
            {
                double differenz = person.Betrag - durchschnitt;

                // Schuldner definieren etc
                foreach (Personen schuldner in urlaub)
                {
                    if (schuldner != person)
                    {
                        // Ternary Operator Bedingung ? true: false;
                        // Es wird überprüft, ob die Schuldliste einen Eintrag für die aktuelle Person
                        // (äussere foreach) enthält
                        // Wenn true, wird der Betrag zurück gegeben, der  der Schuldner and die Person zahlen muss.
                        // Wenn false, wird 0 (double) zurück gegeben
                        double betrag = schuldner.Schulden.ContainsKey(person.Name) ? schuldner.Schulden[person.Name] : 0d;

                        // -1 wird verwendet, damit bei der Berechnung für den Anteil  der Betrag
                        // der aktuellen nicht berücksichtigt wird
                        double anteil = differenz / (urlaub.Count - 1);

                        schuldner.Schulden[person.Name] = betrag + anteil;
                        person.Schulden[schuldner.Name] = schuldner.Schulden[person.Name] * -1;
                    }
                }
            }


            // Ausgabe der Liste
            foreach (Personen person in urlaub)
            {
                Console.WriteLine(person);
            }
        }
    }
}




































/*
//var urlaub = Personen.ParseTXT(path);
//foreach (KeyValuePair<string, double> eintrag in urlaub)
//{
//    Console.WriteLine($"{eintrag.Key}: {eintrag.Value}");
//}
*/