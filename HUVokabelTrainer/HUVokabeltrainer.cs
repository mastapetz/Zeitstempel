/*
 * Klasse Vokabeltrainer
 * Attribute
        private List<string> _woerter;
        private int _index;
        private Random _random;
   Properties
        public int OK { get; private set; }
        public int NOK { get; private set; }
 * 
 * Methoden:
 * 
 * Konstruktor(string path)
 * - File einlesen
 * - _woerter-Liste füllen
 * - Random und OK, NOK Initialisieren
 * 
 * public string RandomWord()
 * => Zufällig einen Eintrag in der Liste suchen
 * - Deutsches Wort zurückgeben
 * - _index merken
 * 
 * public bool Compare(string word)
 * - vergleich englisches word mit dem englischen Wort, dass in der Liste gespeichert ist
 * - OK oder NOK inkrementieren
 * - True oder False zurückgeben
 * - Falls das Wort-Paar erraten wurde, so wird es aus der Liste entfernt
 * 
 * Hinweis für FileLesen
 * 
 * string[] lines = File.ReadAllLines(path);
 * 
 * Beispiel Fileinhalt
 * 
 *      Katze;cat
        Hund;dog
        Tisch;table
        Sessel;chair
        Lampe;lamp
 * 
 */

namespace HUVokabelTrainer
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vokabeltrainer");
            string path = "../../../Vokabel.txt";
            Vokabeltrainer v = new Vokabeltrainer(path);

            while (true)
            {
                Console.Write($"Übersetzung für deutsches Wort {v.RandomWord()}: ");
                string engWord = Console.ReadLine();
                if (engWord == "")
                    break;

                if (v.Compare(engWord))
                    Console.WriteLine("Richtig");
                else
                    Console.WriteLine("Falsch");
            }

            Console.WriteLine($"Richtige Übersetzungen: {v.OK} falsche Übersetzungen: {v.NOK}");
        }
    }
}
