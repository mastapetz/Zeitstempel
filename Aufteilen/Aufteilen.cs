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

            var urlaub = Personen.ParseTXT(path);

            Console.WriteLine(urlaub);




        }
    }
}