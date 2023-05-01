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


        //public static VerkehrsAmpel operator ++(VerkehrsAmpel vAmpel)
        //{
        //    switch (vAmpel.AmpelFarbe)
        //    {
        //        case AmpelZustand.Rot:
        //            vAmpel.AmpelFarbe = AmpelZustand.Gelb;
        //            break;
        //        case AmpelZustand.Gelb:
        //            vAmpel.AmpelFarbe = AmpelZustand.Gruen;
        //            break;
        //        case AmpelZustand.Gruen:
        //            vAmpel.AmpelFarbe = AmpelZustand.Gruenblinken;
        //            break;
        //        case AmpelZustand.Gruenblinken:
        //            vAmpel.AmpelFarbe = AmpelZustand.GruenzuGelb;
        //            break;
        //        case AmpelZustand.GruenzuGelb:
        //            vAmpel.AmpelFarbe = AmpelZustand.GelbzuRot;
        //            break;
        //        case AmpelZustand.GelbzuRot:
        //            vAmpel.AmpelFarbe = AmpelZustand.Rot;
        //            break;
        //        default:
        //            vAmpel.AmpelFarbe = AmpelZustand.Rot;
        //            break;
        //    }

        //    return vAmpel;
        //}




        //public void Blinken()                       //setzt zustand auf Blinken, braucht keinen rückgabe wert
        //{
        //    if (AmpelFarbe == AmpelZustand.Gruen)
        //        AmpelFarbe = AmpelZustand.Gruenblinken;
        //    else if (AmpelFarbe == AmpelZustand.Gruenblinken)
        //        AmpelFarbe = AmpelZustand.GruenzuGelb;
        //    else if (AmpelFarbe == AmpelZustand.GruenzuGelb)
        //        AmpelFarbe = AmpelZustand.Gruen;
        //}
        public static VerkehrsAmpel operator ++(VerkehrsAmpel vAmpel)
        {
            //if (vAmpel.AmpelFarbe == AmpelZustand.Gruenblinken)
            //    vAmpel.AmpelFarbe = AmpelZustand.GruenzuGelb;
            //else
            vAmpel.AmpelFarbe = (AmpelZustand)(((int)vAmpel.AmpelFarbe + 1) % 6);
            // Werte von enum +1 werden durch 6 dividiert, wenn Rest 0 wird wieder auf Wert 0 zurück gesetzt

            return vAmpel;
        }

        public override string ToString() => ($"Verkehrsampel: Ampelzustand: {AmpelFarbe}\n Ort: {AmpelOrt} ");
    }
}
