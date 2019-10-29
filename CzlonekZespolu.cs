using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cwiczenia3.Program;

namespace Cwiczenia3
{
    class CzlonekZespolu : Osoba
    {
        public CzlonekZespolu() //konstruktor nieparametryczny
        { }
        public CzlonekZespolu(string i, string n, string d, string pesel, Plcie p)  //wywolanie konstruktora z klasy Osoba
            : base(i, n, d, pesel, p)
        {
        }
        public string funkcja;
        public override string ToString()   //przesłonienie metody
        {
            return base.ToString() + " " + funkcja;
        }
    }
}
