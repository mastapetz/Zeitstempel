using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HUVokabelTrainer
{
    internal class Vokabeltrainer
    {
        private List<string> _woerter; // = new List<string>();
        private int _index;
        private Random _random;
        string[] lines;

        public int Count { get { return _woerter.Count; } }

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
            //_index = _random.Next(0, lines.Length);
            _index = _random.Next(_woerter.Count / 2);
            string rndWordDeutsch = _woerter[_index * 2];
            //string rndWordE = rndWordTeile[1];
            return rndWordDeutsch;
        }

        public bool Compare(string word)
        {
            //Wenn eingegebenes Wort word richtig
            //OK++
            //return true 
            //Wort aus Liste entfernen
            //wenn falsch
            //NOK++
            if (word == _woerter[_index * 2 + 1])
            {
                OK++;
                _woerter.RemoveAt(_index * 2);
                _woerter.RemoveAt(_index * 2);
                return true;
            }
            else
            {
                NOK++;
                return false;
            }



        }



        public Vokabeltrainer(string path)
        {
            _random = new Random();
            lines = File.ReadAllLines(path);
            _woerter = new List<string>();
            foreach (string line in lines)
            {
                string[] wortPaar = line.Split(';');
                _woerter.Add(wortPaar[0]);
                _woerter.Add(wortPaar[1]);

            }

            OK = 0;
            NOK = 0;
        }
    }
}
