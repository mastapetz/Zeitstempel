/*
 * Bitte Implementiert eine Klassenhierachie für Ampeln.

    Ampel: abstrakte Klasse
    VerkehrsAmpel: von Ampel abgeleitet
    FussgaengerAmpel: von Ampel abgeleitet


enum AmpelZustand

    {
        Rot,
        Gelb,
        Grün,
        Grünblinken,
        GrünzuGelb,
        GelbzuRot
    }

    internal abstract class Ampel

    {
        internal AmpelZustand Zustand { get; set; }
        internal string Ort { get; set; }
        internal Ampel(string ort, AmpelZustand zustand = AmpelZustand.Grün)
        {
            Zustand = zustand;
            Ort = ort;  
        }

        // Schalten schaltet von einem zum nächsten Zustand der Ampel z.B von rot nach gelb
        // Die Ampelzyklen wiederholen sich dabei immer
        // z.B Fussgängerampel: rot => grün => grünblinken => rot => grün => grünblinken u.s.w

        internal abstract void Schalten();

.    }


Die Zustandübergänge der Verkehrsampel und der Fussgängerampel sind hier zu finden: https://www.wien.gv.at/verkehr/ampeln/ampelkunde.html
Zusätzlich bitte auch für die Verkehrsampel und Fussgängerampel ein Operatoroverloading für den Operator ++ machen. 
Ein Operatoroverloading kann nicht vererbt werden, weil hier die Klasse als Typ verwendet werden muss.


*/
namespace AmpelHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * VerkehrsAmpel amPlatz1 = new VerkehrsAmpel("Am Platz 1");
             * Console.WriteLine(amPlatz1);
             * Console.WriteLine("====== Am Platz 1");
             * for (int i = 0; i < 5; i++)
             * {
             *    Console.WriteLine(amPlatz1);
             *    amPlatz1.Blinken();
             *    ++amPlatz1;
             *    Console.WriteLine(amPlatzF1);
             *}
             */

            VerkehrsAmpel amPlatz2 = new VerkehrsAmpel("Am Platz 2", AmpelZustand.Rot);
            FussGaengerAmpel amPlatzF1 = new FussGaengerAmpel("Am Platz F1", AmpelZustand.Gruen);
            for (int i = 0; i < 12; i++)
            {
                //Console.WriteLine(amPlatz2); //Wenn vor Blinken() wird Grünblinken nie angezeigt ????

                Console.WriteLine(amPlatz2 + "\n" + amPlatzF1);
                //amPlatz2.Blinken();
                Console.WriteLine("---------");
                //Console.WriteLine(amPlatzF1);

                //Console.WriteLine(amPlatz2);
                if (amPlatzF1.AmpelFarbe == AmpelZustand.Rot)
                    ++amPlatz2;
                if (amPlatz2.AmpelFarbe == AmpelZustand.Rot)
                    amPlatzF1++;
            }

        }
    }
}