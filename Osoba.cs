using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
using static Cwiczenia3.Program;

namespace Cwiczenia3
{
    class Osoba
    {
        //pola klasy
        private string imie;
        public string nazwisko { get; set; }
        private DateTime DataUrodzenia;
        private string PESEL;
        private Plcie plec;


        //metody akcesorowe
        public string Imie { get => imie; set => imie = value; }
        public DateTime dataUrodzenia
        {
            get { return DataUrodzenia; }
            set { DataUrodzenia = value; }
        }
        public string Pesel
        {
            get { return PESEL; }
            set { PESEL = value; }
        }
        public Plcie Plec
        {
            get { return Plec1; }
            set { Plec1 = value; }
        }

        public Plcie Plec1 { get => plec; set => plec = value; }

        //konstruktory (parametryczne i nieparametryczne!!)
        public Osoba()
        {
            imie = null;
            nazwisko = null;
            dataUrodzenia = DateTime.MinValue;
            PESEL = "00000000000";
        }

        public Osoba(string i, string n)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public Osoba(string i, string n, string d, string pesel, Plcie p)
        {
            imie = i;
            nazwisko = n;
            DateTime data;
            DateTime.TryParseExact(d, new[] { "yyyy-mm-dd", "yyyy/mm/dd", "mm/dd/yy", "dd-mm-yy" }, null, DateTimeStyles.None, out data);
            dataUrodzenia = data;
            Plec1 = p;
            PESEL = pesel;
        }
        //inne metody

        public bool CheckPESEL(string p)    //jak sprawdzic, czy nr pesel ma 11 liter?
        {
            if (p.Length != 11) return false;
            Regex rgx = new Regex(@"\d{ 11 }");
            if (!rgx.IsMatch(p)) return false;
            if (p[9] % 2 != (int)Plec) return false;
            return true;

        }
        public int Wiek()
        {
            return (DateTime.Now.Year - DataUrodzenia.Year);
        }
        public override string ToString()
        {
            return this.imie + " " + nazwisko + " " + dataUrodzenia.ToShortDateString() + " " + Plec1;
        }
    }
}
