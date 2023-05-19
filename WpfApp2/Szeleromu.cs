using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Szeleromu
    {
        string helyszin;
        int egyseg;
        int teljesitmeny;
        int mukodesEve;

        public Szeleromu(string helyszin, int egyseg, int teljesitmeny, int mukodesEve)
        {
            this.helyszin = helyszin;
            this.egyseg = egyseg;
            this.teljesitmeny = teljesitmeny;
            this.mukodesEve = mukodesEve;
        }

        public string Helyszin { get => helyszin;}
        public int Egyseg { get => egyseg;}
        public int Teljesitmeny { get => teljesitmeny;}
        public int MukodesEve { get => mukodesEve;}

        public char kategoria()
        {
            if (teljesitmeny > 1000)
            {
                return('A');
            }
            if (teljesitmeny < 1000 && teljesitmeny > 500)
            {
                return('B');
            }
            else
            {
                return ('C');
            }
        }
    }
}
