using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpelHW
{
    internal class FussGaengerAmpel : Ampel
    {
        public FussGaengerAmpel(string ort, AmpelZustand farbe = AmpelZustand.Gruen) : base(ort, farbe)
        {
        }
        public void Blinken()                       //setzt zustand auf Blinken, braucht keinen rückgabe wert
        {
            AmpelFarbe = AmpelZustand.Gruenblinken;
        }
        public static FussGaengerAmpel operator ++(FussGaengerAmpel fAmpel)
        {
            //vAmpel.AmpelFarbe++;
            fAmpel.AmpelFarbe = (AmpelZustand)(((int)fAmpel.AmpelFarbe + 1) % 2);

            return fAmpel;
        }

        public override string ToString() => ($"FußgängerAmpel: Ampelzustand: {AmpelFarbe}\n Ort: {AmpelOrt}");
    }
}
