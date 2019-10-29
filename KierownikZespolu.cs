using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cwiczenia3.Program;

namespace Cwiczenia3
{
    class KierownikZespolu : Osoba
    {
        public KierownikZespolu()   //konstruktor nieparametryczny
        { }
        public KierownikZespolu(string i, string n, string d, string pesel, Plcie p, int doswiadczenie)  //wywolanie konstruktora z klasy Osoba
            : base(i, n, d, pesel, p)
        {
            this.doswiadczenie = doswiadczenie;
        }
        public int doswiadczenie;
        public override string ToString()   //przesłonienie metody
        {
            return base.ToString() + " " + doswiadczenie;
        }
    }
}
