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
        public DateTime _start;
        public DateTime Start
        {
            get; set;
        }


        //Endzeit
        public DateTime _end;
        public DateTime End
        {
            get { return _end; }
            set
            {
                //if (_start > value)

                if (_start.Hour > _end.Hour)
                {
                    throw new ArgumentException("Falsche Zeiteingabe");
                }
                _end = value;
            }
        }
        //Zeitspanne

        internal TimeSpan _zeit;
        internal TimeSpan Zeit { get; }

        //Konstruktor

        internal ArbeitsZeitKlasse(DateTime startZeit, DateTime endZeit)
        {
            _start = startZeit;
            _end = endZeit;
            _zeit = _end - _start;
            if (_zeit > TimeSpan.Parse("6:30"))
            {
                _zeit -= TimeSpan.Parse("0:30");
            }

        }

        //ToString

        public override string ToString()
        {
            return $"Eingangszeit: {_start}  Endzeit: {_end} Dauer: {_zeit}";
        }

    }
}
