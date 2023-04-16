namespace Arbeitszeit
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //unter 6.5 stunden v2 ✔
            DateTime startStempel1 = new DateTime(2023, 4, 16, 9, 0, 0);
            DateTime endStempel1 = new DateTime(2023, 4, 16, 10, 0, 0);
            ArbeitsZeitKlasse StempelPaar1 = new ArbeitsZeitKlasse(startStempel1, endStempel1);
            Console.WriteLine(StempelPaar1);
            //über  6.5 stunden v2 ✔
            DateTime startStempel2 = new DateTime(2023, 4, 16, 10, 0, 0);
            DateTime endStempel2 = new DateTime(2023, 4, 16, 18, 30, 0);
            ArbeitsZeitKlasse StempelPaar2 = new ArbeitsZeitKlasse(startStempel2, endStempel2);
            Console.WriteLine(StempelPaar2);
            //falsche Zeit v2 ✔
            // Nach einmal verwenden die überprüfungen ->💀
            // Nach änderung von zeile 18 und 34 funktioniert es wieder ✔

            //DateTime startStempel3 = new DateTime(2023, 4, 16, 18, 0, 0);
            //DateTime endStempel3 = new DateTime(2023, 4, 16, 10, 30, 0);
            //ArbeitsZeitKlasse StempelPaar3 = new ArbeitsZeitKlasse(startStempel3, endStempel3);
            //Console.WriteLine(StempelPaar3);

            //falsche Zeit v2 über 12h ✔
            //DateTime startStempel4 = new DateTime(2023, 4, 16, 7, 0, 0);
            //DateTime endStempel4 = new DateTime(2023, 4, 16, 21, 30, 0);
            //ArbeitsZeitKlasse StempelPaar4 = new ArbeitsZeitKlasse(startStempel4, endStempel4);
            //Console.WriteLine(StempelPaar4);

            Console.WriteLine("===========================================================================");
            /*
             * Erste Variante, bevor ich wusste, wie man die DateTime Parmeter richtig übergibt)
             * Führt zum selben ergebnis und kann verwendet werden, wenn man den Benutzer die Zeiten selber eingeben lässt
             * damit die Strings richtig ins DateTime Format verwandelt werden können
             */
            //unter 6.5 stunden ✔
            DateTime eingangStempelA1 = DateTime.Parse("9:00");
            DateTime ausgangsStempelA1 = DateTime.Parse("15:00");
            ArbeitsZeitKlasse StempelPaarA1 = new(eingangStempelA1, ausgangsStempelA1);
            Console.WriteLine(StempelPaarA1);
            //*******************
            Console.WriteLine("----------------------------------");
            //*******************
            //über 6.5 stunden ✔
            DateTime eingangStempel2 = DateTime.Parse("9:00");
            DateTime ausgangsStempel2 = DateTime.Parse("19:00");
            ArbeitsZeitKlasse StempelPaarA2 = new(eingangStempel2, ausgangsStempel2);
            Console.WriteLine(StempelPaarA2);
            //*******************
            Console.WriteLine("----------------------------------");
            //*******************
            //falsche Zeit✔
            DateTime eingangStempel3 = DateTime.Parse("11:00");
            DateTime ausgangsStempel3 = DateTime.Parse("9:00");
            ArbeitsZeitKlasse StempelPaarA3 = new(eingangStempel3, ausgangsStempel3);
            Console.WriteLine(StempelPaarA3);



        }
    }
}
/*
 * Erste Überlegung, nicht getestet mit Verbesserungen und Korrekturen des Klassen Codes
 * 
 * ArbeitsZeitKlasse ZeitStempelEins = new(DateTime.Now.AddHours(-7), DateTime.Now);
 * Zeit._end = DateTime.Now;
 * Zeit._start = Zeit._end.AddHours(-7);
 * 
*/