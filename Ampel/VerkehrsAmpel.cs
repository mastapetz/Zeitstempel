using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpelHW
{
    internal class VerkehrsAmpel : Ampel
    {
        public VerkehrsAmpel(string ort, AmpelZustand farbe = AmpelZustand.Gruen) : base(ort, farbe)
        {
            //übernimmt Konstruktor von anstrakter klasse und fügt Werte
            //von Verkehrsampel ein
        }

        public void Blinken()                       //setzt zustand auf Blinken, braucht keinen rückgabe wert
        {
            if (AmpelFarbe == AmpelZustand.Gruen)
                AmpelFarbe = AmpelZustand.Gruenblinken;
            else if (AmpelFarbe == AmpelZustand.Gruenblinken)
                AmpelFarbe = AmpelZustand.Gruen;
        }
        public static VerkehrsAmpel operator ++(VerkehrsAmpel vAmpel)
        {
            //if (vAmpel.AmpelFarbe == AmpelZustand.Gruenblinken)
            //    vAmpel.AmpelFarbe = AmpelZustand.GruenzuGelb;
            //else
            vAmpel.AmpelFarbe = (AmpelZustand)(((int)vAmpel.AmpelFarbe + 1) % 6);

            return vAmpel;
        }

        public override string ToString() => ($"Verkehrsampel: Ampelzustand: {AmpelFarbe}\n Ort: {AmpelOrt} ");
    }
}
