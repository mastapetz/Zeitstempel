using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitszeit
{
    internal class ArbeitsZeitKlasse
    {
        //Anfangszeit
        private DateTime _start;
        public DateTime Start
        {
            get { return _start; }
            set
            {
                if (_end != default(DateTime) && value > _end)  //if (value > _end) führte dazu, das alle Startzeiten als nach Endzeiten gesehen wurden
                {
                    throw new ArgumentException("Startzeit darf nicht nach Endzeit sein\n");
                }
                _start = value;
            }
        }


        //Endzeit
        private DateTime _end;
        public DateTime End
        {
            get { return _end; }
            set
            {
                if (_start > value)  //if (value < _start) wirft selben fehler wie Zeile 18 wenn nicht erweitet
                {
                    throw new ArgumentException("Endzeit darf nicht vor Startzeit sein\n");
                }
                _end = value;
            }
        }
        //Zeitspanne

        private TimeSpan _zeit()
        {
            TimeSpan _zeit = _end - _start;
            /*
            * if (_zeit > TimeSpan.Parse("6:30"))
            *   {
            *        _zeit -= TimeSpan.Parse("0:30");
            *   }
            *   Macht zwar das Selbe, aber unschön.
            */
            if (_zeit.TotalHours > 6.5)  //Checkt ob die ZeitSpanne über 6,5 stunden ist
            {
                _zeit = _zeit.Subtract(TimeSpan.FromMinutes(30)); //"einfache" subtrahier methode, mittels welche direkt  von den Minuten 30 abgezogen werden können
            }
            if (_zeit.TotalHours > 12)  //Wenn mehr als 12 Stunden, Fehlermeldung
            {
                throw new ArgumentException("Zeitspanne kann nicht über 12 Stunden sein\n");
            }
            return _zeit;
        }
        public TimeSpan Zeit
        {
            get { return _zeit(); }
        }

        //Konstruktor

        internal ArbeitsZeitKlasse(DateTime startZeit, DateTime endZeit)
        {
            /*
            * //_start = startZeit;
            * //_end = endZeit;
            * Wenn wie oben geschrieben, werden wird Start und End ignoriert
            * wodurch nie kontrolliert wird ob die Zeiten stimmen
            */
            Start = startZeit;
            End = endZeit;


        }

        //ToString

        public override string ToString()
        {
            return $"Eingangszeit: {_start}  Endzeit: {_end} Dauer: {_zeit()}";
        }

    }
}
