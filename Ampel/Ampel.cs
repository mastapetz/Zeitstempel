using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpelHW
{
    enum AmpelZustand

    {
        Rot,            //Wert 0
        Gelb,           //Wert 1
        Gruen,          //Wert 2
        Gruenblinken,   //Wert 3
        GruenzuGelb,    //Wert 4
        GelbzuRot       //Wert 5
    }
    internal abstract class Ampel
    {
        internal AmpelZustand AmpelFarbe { get; set; }  //in vorgabe AmpelFarbe = Zustand
                                                        //benötig internal
        internal string AmpelOrt { get; set; }           //in vorgabe Ort

        internal Ampel(string ort, AmpelZustand farbe = AmpelZustand.Gruen)  //Wenn man einen optionalen default beim ERSTEN parameter eingibt,
                                                                             //brauchen ihn alle
        {
            AmpelFarbe = farbe;
            AmpelOrt = ort;
        }

    }
}
