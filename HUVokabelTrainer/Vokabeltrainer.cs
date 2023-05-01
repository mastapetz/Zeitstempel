using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUVokabelTrainer
{
    internal class Vokabeltrainer : IComparable<string>
    {
        private List<string> _woerter = new List<string>();
        private int _index;
        private Random _random;
        string[] lines;
        private int _ok;
        private int _nok;

        public int OK
        {
            get;
            private set;
        }

        public int NOK
        {
            get;
            private set;
        }

        public string RandomWord()
        {



            string rndWord = "Blabla";
            return rndWord;




        }

        public bool Compare(string word)
        {
            //Wenn eingegebenes Wort word richtig
            //OK++
            //return true 
            //Wort aus Liste entfernen
            //wenn falsch
            //NOK++
            return false;



        }

        public int CompareTo(string? other)
        {
            throw new NotImplementedException();
        }

        public Vokabeltrainer(string path)
        {
            lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] wortPaar = line.Split(';');
                _woerter.Add(wortPaar[0]);
                _woerter.Add(wortPaar[1]);

            }

            _random = new Random();
            _index = _random.Next(lines.Length);
            OK = _ok;
            NOK = _nok;


        }
    }
}
