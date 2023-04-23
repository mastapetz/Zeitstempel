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

        public static FussGaengerAmpel operator ++(FussGaengerAmpel fAmpel)
        {
            switch (fAmpel.AmpelFarbe)
            {
                case AmpelZustand.Rot:
                    fAmpel.AmpelFarbe = AmpelZustand.Gruen;
                    break;
                case AmpelZustand.Gruen:
                    fAmpel.AmpelFarbe = AmpelZustand.Gruenblinken;
                    break;
                case AmpelZustand.Gruenblinken:
                    fAmpel.AmpelFarbe = AmpelZustand.Rot;
                    break;
                default:
                    fAmpel.AmpelFarbe = AmpelZustand.Rot;
                    break;
            }


            //vAmpel.AmpelFarbe++;
            //fAmpel.AmpelFarbe = (AmpelZustand)(((int)fAmpel.AmpelFarbe + 1) % 2);
            return fAmpel;
        }

        public override string ToString() => ($"FußgängerAmpel: Ampelzustand: {AmpelFarbe}\n Ort: {AmpelOrt}");
    }
}
